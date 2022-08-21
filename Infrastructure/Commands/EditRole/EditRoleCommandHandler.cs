using Infrastructure.Identity.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.EditRole
{
    public class EditRoleCommandHandler : IHandleAsync<EditRoleCommand>
    {
        private readonly RoleManager<Role> _roleManager;

        public EditRoleCommandHandler(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task HandleAsync(EditRoleCommand command)
        {
            var role = await _roleManager.FindByIdAsync(command.Id.ToString());
            role.Name = command.Name;
            role.RoleDescription = command.RoleDescription;
            await _roleManager.UpdateAsync(role);
        }
    }
}
