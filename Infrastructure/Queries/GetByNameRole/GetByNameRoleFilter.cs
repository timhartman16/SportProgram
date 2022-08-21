using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Queries.GetByNameRole
{
    public class GetByNameRoleFilter
    {
        public string Name { get; set; }

        public GetByNameRoleFilter(string name)
        {
            Name = name;
        }
    }
}
