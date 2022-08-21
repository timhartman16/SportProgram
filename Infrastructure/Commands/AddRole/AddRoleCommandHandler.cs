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

namespace Infrastructure.Commands.AddRole
{
    public class AddRoleCommandHandler : IHandleAsync<AddRoleCommand>
    {
        private readonly RoleManager<Role> _roleManager;

        public AddRoleCommandHandler(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task HandleAsync(AddRoleCommand command)
        {
            var role = new Role(command.Name, command.RoleDescription);
            await _roleManager.CreateAsync(role);
        }
    }
}
