using Infrastructure.Commands.Login;
using Infrastructure.Commands.Logout;
using Infrastructure.DTO;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SportProgram.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;

        public AccountController(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }

        [HttpPost]
        [Route("Login")]
        public async Task Login(LoginDto login)
        {
            var command = new LoginCommand(login.Login, login.Password, login.RememberMe);
            await _commandDispatcher.HandleAsync(command);
        }

        [HttpPost]
        [Route("Logout")]
        public async Task Logout()
        {
            var command = new LogoutCommand();
            await _commandDispatcher.HandleAsync(command);
        }
    }
}
