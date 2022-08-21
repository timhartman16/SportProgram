using Infrastructure.Identity.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IHandleAsync<DeleteUserCommand>
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public DeleteUserCommandHandler(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task HandleAsync(DeleteUserCommand command)
        {
            var user = await _userManager.FindByIdAsync(command.Id.ToString());
            await _userManager.DeleteAsync(user);
        }
    }
}
