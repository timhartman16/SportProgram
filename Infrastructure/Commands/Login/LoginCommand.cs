using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.Login
{
    public class LoginCommand
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }

        public LoginCommand(string login, string password, bool rememberMe)
        {
            Login = login;
            Password = password;
            RememberMe = rememberMe;
        }
    }
}
