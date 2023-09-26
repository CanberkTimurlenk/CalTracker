using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Repository.Configurations
{
    public class UserDataConfiguration : IEntityTypeConfiguration<UserData>
    {

        public void Configure(EntityTypeBuilder<UserData> builder)
        {

        }
    }
}
