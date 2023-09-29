using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configurations
{
    public class UserAimConfigurations : IEntityTypeConfiguration<Aim>
    {
        public void Configure(EntityTypeBuilder<Aim> builder)
        {
            builder.Property(ua => ua.Name).HasMaxLength(50);
            builder.Property(ua => ua.Coefficient).HasMaxLength(4);
        }
    }
}
