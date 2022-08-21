using Infrastructure.Identity.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.Logout
{
    public class LogoutCommandHandler : IHandleAsync<LogoutCommand>
    {
        private readonly SignInManager<User> _signInManager;

        public LogoutCommandHandler(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task HandleAsync(LogoutCommand command)
        {
            await _signInManager.SignOutAsync();
        }
    }
}
