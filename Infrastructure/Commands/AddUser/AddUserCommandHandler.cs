using Infrastructure.Identity.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.AddUser
{
    public class AddUserCommandHandler : IHandleAsync<AddUserCommand>
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public AddUserCommandHandler(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task HandleAsync(AddUserCommand command)
        {
            var user = new User(command.UserName, command.Password);
            await _userManager.CreateAsync(user, user.Password);
            var findRole = await _roleManager.FindByNameAsync(command.Role);
            if (findRole != null)
                await _userManager.AddToRoleAsync(user, findRole.Name);
        }
    }
}
