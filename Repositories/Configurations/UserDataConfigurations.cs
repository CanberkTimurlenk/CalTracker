using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Repositories.Configurations
{
    public class UserDataConfiguration : IEntityTypeConfiguration<UserData>
    {

        public void Configure(EntityTypeBuilder<UserData> builder)
        {
            //builder.ToTable("UserDatas");

            //builder.HasKey(ud => ud.Id);

            //builder.Property(ud => ud.DailyCalorie).HasColumnType("double");
            //builder.Property(ud => ud.DailyProtein).HasColumnType("double");
            //builder.Property(ud => ud.DailyCarbonhidrate).HasColumnType("double");
            //builder.Property(ud => ud.DailyFat).HasColumnType("double");
            //builder.Property(ud => ud.BodyMassIndex).HasColumnType("double");
            //builder.Property(ud => ud.BmiStatus);
            //builder.Property(ud => ud.RequiredCalorie).HasColumnType("double");
            //builder.Property(ud => ud.WaterAmount).HasColumnType("double");
            builder.Property(ud => ud.Date).HasColumnType("date");

            //builder.HasOne(ud => ud.User).WithMany(ud => ud.UserData).HasForeignKey(ud => ud.UserId);
        }
    }
}
