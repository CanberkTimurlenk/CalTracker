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
    public class FoodConfigurations : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Calorie).HasMaxLength(8);
            builder.Property(x => x.Fat).HasMaxLength(8);
            builder.Property(x => x.Carbonhidrate).HasMaxLength(8);
            builder.Property(x => x.Protein).HasMaxLength(8);
            //desc ve imagepath maxlength vermedik
        }
    }
}
