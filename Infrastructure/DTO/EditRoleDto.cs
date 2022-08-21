using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DTO
{
    public class EditRoleDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string RoleDescription { get; set; }
    }
}
