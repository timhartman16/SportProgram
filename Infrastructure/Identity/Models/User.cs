using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity.Models
{
    public class User : IdentityUser
    {
        public string Password { get; set; }

        public User(string userName, string password)
        {
            Id = Guid.NewGuid().ToString();
            UserName = userName;
            Password = password;
        }
    }
}
