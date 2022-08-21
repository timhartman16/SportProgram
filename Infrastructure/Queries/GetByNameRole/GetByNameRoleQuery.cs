using AutoMapper;
using Infrastructure.DTO;
using Infrastructure.Identity.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Queries.GetByNameRole
{
    public class GetByNameRoleQuery : IGetByNameRoleQuery
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly IMapper _mapper;

        public GetByNameRoleQuery(RoleManager<Role> roleManager, IMapper mapper)
        {
            _roleManager = roleManager;
            _mapper = mapper;
        }
        public async Task<RoleDto> ExecuteAsync(GetByNameRoleFilter criteria)
        {
            var role = await _roleManager.FindByNameAsync(criteria.Name);
            return _mapper.Map<RoleDto>(role);
        }
    }
}
