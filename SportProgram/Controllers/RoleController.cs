using Infrastructure.Commands.AddRole;
using Infrastructure.Commands.DeleteRole;
using Infrastructure.Commands.EditRole;
using Infrastructure.DTO;
using Infrastructure.Interfaces;
using Infrastructure.Queries.GetAllRole;
using Infrastructure.Queries.GetByNameRole;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportProgram.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IGetByNameRoleQuery _getByNameRoleQuery;
        private readonly IGetAllRoleQuery _getAllRoleQuery;

        public RoleController(ICommandDispatcher commandDispatcher,
                              IGetByNameRoleQuery getByNameRoleQuery, IGetAllRoleQuery getAllRoleQuery)
        {
            _commandDispatcher = commandDispatcher;
            _getByNameRoleQuery = getByNameRoleQuery;
            _getAllRoleQuery = getAllRoleQuery;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<RoleDto> GetAll()
        {
            return _getAllRoleQuery.Execute();
        }

        [HttpGet]
        [Route("GetByName/{name}")]
        public async Task<RoleDto> GetByName(string name)
        {
            var filter = new GetByNameRoleFilter(name);
            var role = await _getByNameRoleQuery.ExecuteAsync(filter);
            return role;
        }

        [HttpPost]
        [Route("CreateRole")]
        public async Task<RoleDto> AddRole(AddRoleDto role)
        {
            var command = new AddRoleCommand(role.Name, role.RoleDescription);
            await _commandDispatcher.HandleAsync(command);
            return await GetByName(role.Name);
        }

        [HttpPut]
        [Route("EditRole")]
        public async Task EditRole(EditRoleDto role)
        {
            var command = new EditRoleCommand(role.Id, role.Name, role.RoleDescription);
            await _commandDispatcher.HandleAsync(command);
        }

        [HttpDelete]
        [Route("DeleteRole/{id}")]
        public async Task DeleteRole(Guid id)
        {
            var command = new DeleteRoleCommand(id);
            await _commandDispatcher.HandleAsync(command);
        }
    }
}
