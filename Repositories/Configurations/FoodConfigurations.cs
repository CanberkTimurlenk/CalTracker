using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configurations
{
    public class FoodConfigurations : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(f => f.Name).HasMaxLength(100);
            builder.Property(f => f.Calorie).HasMaxLength(8);
            builder.Property(f => f.Fat).HasMaxLength(8);
            builder.Property(f => f.Carbonhidrate).HasMaxLength(8);
            builder.Property(f => f.Protein).HasMaxLength(8);
            //desc ve imagepath maxlength vermedik
        }        
    }
}
