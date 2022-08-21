using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity.Models
{
    public class Role : IdentityRole
    {
        public string RoleDescription { get; set; }

        public Role(string name, string roleDescription)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            RoleDescription = roleDescription;
        }
    }
}
