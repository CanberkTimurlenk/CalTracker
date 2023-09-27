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
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x=>x.FirstName).HasMaxLength(20);
            builder.Property(x=>x.LastName).HasMaxLength(30);
            builder.Property(x=>x.Email).HasMaxLength(50);
            builder.Property(x=>x.Password).HasMaxLength(30);
            builder.Property(x=>x.Height).HasMaxLength(5);
            builder.Property(x=>x.Weight).HasMaxLength(5);
        }
    }
}
