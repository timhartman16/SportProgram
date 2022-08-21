using Infrastructure.DTO;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Queries.GetCurrentUser
{
    public interface IGetCurrentUserQuery : IQueryAsync<GetCurrentUserFilter, Task<UserDto>>
    {
    }
}
