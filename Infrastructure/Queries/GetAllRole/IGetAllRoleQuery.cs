using Infrastructure.DTO;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Queries.GetAllRole
{
    public interface IGetAllRoleQuery : IQuery<IEnumerable<RoleDto>>
    {

    }
}
