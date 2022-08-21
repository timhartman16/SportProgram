using Infrastructure.DTO;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Queries.GetByNameRole
{
    public interface IGetByNameRoleQuery : IQueryAsync<GetByNameRoleFilter, Task<RoleDto>>
    {
        //Task<RoleDto> ExecuteAsync(GetByNameRoleFilter criteria);
    }
}
