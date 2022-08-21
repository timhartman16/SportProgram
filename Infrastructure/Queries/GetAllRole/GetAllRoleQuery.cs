using AutoMapper;
using Infrastructure.DTO;
using Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Queries.GetAllRole
{
    public class GetAllRoleQuery : IGetAllRoleQuery
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly IMapper _mapper;

        public GetAllRoleQuery(RoleManager<Role> roleManager, IMapper mapper)
        {
            _roleManager = roleManager;
            _mapper = mapper;
        }
        public IEnumerable<RoleDto> Execute()
        {
            var roles = _roleManager.Roles.ToList();
            return _mapper.Map<IEnumerable<RoleDto>>(roles);
        }
    }
}
