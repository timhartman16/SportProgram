using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.EditRole
{
    public class EditRoleCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string RoleDescription { get; set; }

        public EditRoleCommand(Guid id, string name, string roleDescription)
        {
            Id = id;
            Name = name;
            RoleDescription = roleDescription;
        }
    }
}
