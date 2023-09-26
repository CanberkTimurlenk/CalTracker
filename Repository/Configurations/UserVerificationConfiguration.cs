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
    public class UserVerificationConfiguration : IEntityTypeConfiguration<UserVerification>
    {
        public void Configure(EntityTypeBuilder<UserVerification> builder)
        {
            builder.HasKey(uv => uv.UserId);

            builder.HasOne(uv => uv.User)
                   .WithOne(u => u.UserVerification)
                   .HasForeignKey<UserVerification>(uv => uv.UserId);
        }
    }
}
