using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.AddUser
{
    public class AddUserCommand
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public AddUserCommand(string userName, string password, string role)
        {
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}
