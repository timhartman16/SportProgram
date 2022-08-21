using Domain.SportTrainingAggregate;
using Infrastructure.Persistence.EnitityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class SportProgramDbContext : DbContext
    {
        public SportProgramDbContext(DbContextOptions<SportProgramDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<SportTraining> SportTraining { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SportTrainingConfiguration());
        }
    }
}
