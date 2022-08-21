using AutoMapper;
using Infrastructure.DTO;
using Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Queries.GetAllUser
{
    public class GetAllUserQuery : IGetAllUserQuery
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public GetAllUserQuery(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        public IEnumerable<UserDto> Execute()
        {
            var users = _userManager.Users.ToList();
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }
    }
}
