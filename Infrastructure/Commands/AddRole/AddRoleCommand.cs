using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.AddRole
{
    public class AddRoleCommand
    {
        public string Name { get; set; }
        public string RoleDescription { get; set; }

        public AddRoleCommand(string name, string roleDescription)
        {
            Name = name;
            RoleDescription = roleDescription;
        }
    }
}
