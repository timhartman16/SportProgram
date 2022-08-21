using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Queries.GetCurrentUser
{
    public class GetCurrentUserFilter
    {
        public ClaimsPrincipal Claims { get; set; }

        public GetCurrentUserFilter(ClaimsPrincipal claims)
        {
            Claims = claims;
        }
    }
}
