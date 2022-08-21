using Infrastructure.Commands.AddUser;
using Infrastructure.Commands.DeleteUser;
using Infrastructure.DTO;
using Infrastructure.Interfaces;
using Infrastructure.Queries.GetAllUser;
using Infrastructure.Queries.GetCurrentUser;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportProgram.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IGetAllUserQuery _getAllUserQuery;
        private readonly IGetCurrentUserQuery _getCurrentUserQuery;

        public UserController(ICommandDispatcher commandDispatcher, IGetAllUserQuery getAllUserQuery)
        {
            _commandDispatcher = commandDispatcher;
            _getAllUserQuery = getAllUserQuery;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<UserDto> GetAll()
        {
            return _getAllUserQuery.Execute();
        }

        [HttpGet]
        [Route("GetCurrentUserName")]
        public async Task<UserDto> GetCurrentUserName()
        {
            var filter = new GetCurrentUserFilter(HttpContext.User);
            return await _getCurrentUserQuery.ExecuteAsync(filter);
        }

        [HttpPost]
        [Route("CreateUser")]
        public async Task AddUser(AddUserDto user)
        {
            var command = new AddUserCommand(user.UserName, user.Password, user.Role);
            await _commandDispatcher.HandleAsync(command);
        }


        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public async Task DeleteUser(Guid id)
        {
            var command = new DeleteUserCommand(id);
            await _commandDispatcher.HandleAsync(command);
        }
    }
}
