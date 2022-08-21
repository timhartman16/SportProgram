using Infrastructure.Identity.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.Login
{
    public class LoginCommandHandler : IHandleAsync<LoginCommand>
    {
        private readonly SignInManager<User> _signInManager;

        public LoginCommandHandler(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task HandleAsync(LoginCommand command)
        {
            await _signInManager.PasswordSignInAsync(command.Login, command.Password, command.RememberMe, false);
        }
    }
}
