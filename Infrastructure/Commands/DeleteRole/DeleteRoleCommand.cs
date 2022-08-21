using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.DeleteRole
{
    public class DeleteRoleCommand
    {
        public Guid Id { get; set; }

        public DeleteRoleCommand(Guid id)
        {
            Id = id;
        }
    }
}
