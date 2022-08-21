using Infrastructure.DTO;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Queries.GetAllUser
{
    public interface IGetAllUserQuery : IQuery<IEnumerable<UserDto>>
    {
    }
}
