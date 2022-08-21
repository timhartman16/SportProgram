using Infrastructure.Identity.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.DeleteRole
{
    public class DeleteRoleCommandHandler : IHandleAsync<DeleteRoleCommand>
    {
        private readonly RoleManager<Role> _roleManager;

        public DeleteRoleCommandHandler(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task HandleAsync(DeleteRoleCommand command)
        {
            var role = await _roleManager.FindByIdAsync(command.Id.ToString());
            await _roleManager.DeleteAsync(role);
        }
    }
}
