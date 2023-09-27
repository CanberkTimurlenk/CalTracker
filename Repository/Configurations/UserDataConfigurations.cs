using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Repository.Configurations
{
    public class UserDataConfiguration : IEntityTypeConfiguration<UserData>
    {

        public void Configure(EntityTypeBuilder<UserData> builder)
        {
            //builder.ToTable("UserDatas");

            //builder.HasKey(x => x.Id);

            //builder.Property(x => x.DailyCalorie).HasColumnType("double");
            //builder.Property(x => x.DailyProtein).HasColumnType("double");
            //builder.Property(x => x.DailyCarbonhidrate).HasColumnType("double");
            //builder.Property(x => x.DailyFat).HasColumnType("double");
            //builder.Property(x => x.BodyMassIndex).HasColumnType("double");
            //builder.Property(x => x.BmiStatus);
            //builder.Property(x => x.RequiredCalorie).HasColumnType("double");
            //builder.Property(x => x.WaterAmount).HasColumnType("double");
            builder.Property(x => x.Date).HasColumnType("date");

            //builder.HasOne(x => x.User).WithMany(x => x.UserData).HasForeignKey(x=>x.UserId);
        }
    }
}
