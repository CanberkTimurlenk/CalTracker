using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configurations
{
    public class UserAimConfigurations : IEntityTypeConfiguration<Aim>
    {
        public void Configure(EntityTypeBuilder<Aim> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Coefficient).HasMaxLength(4);
        }
    }
}
