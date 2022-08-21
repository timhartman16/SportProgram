using Domain.SportTrainingAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EnitityConfigurations
{
    public class SportTrainingConfiguration : IEntityTypeConfiguration<SportTraining>
    {
        public void Configure(EntityTypeBuilder<SportTraining> builder)
        {
            builder.ToTable("SportTrainings").HasKey(x => x.Id);
        }
    }
}
