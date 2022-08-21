using Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class SportProgramIdentityDbContext : IdentityDbContext<User, Role, string>
    {
        public SportProgramIdentityDbContext(DbContextOptions<SportProgramIdentityDbContext> options) : base(options)
        {

        }
    }
}
