using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.DeleteUser
{
    public class DeleteUserCommand
    {
        public Guid Id { get; set; }

        public DeleteUserCommand(Guid id)
        {
            Id = id;
        }
    }
}
