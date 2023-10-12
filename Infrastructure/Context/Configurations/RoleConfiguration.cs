using Core.Entities;
using Core.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasData(
                new ApplicationRole
                {
                    Id = 1,
                    Name = UserTypes.Admin.ToString(),
                    NormalizedName = UserTypes.Admin.ToString().ToUpper(),
                },
                new ApplicationRole
                {
                    Id = 2,
                    Name = UserTypes.User.ToString(),
                    NormalizedName = UserTypes.User.ToString().ToUpper(),
                },
                new ApplicationRole
                {
                    Id = 3,
                    Name = UserTypes.Partner.ToString(),
                    NormalizedName = UserTypes.Partner.ToString().ToUpper(),
                });
        }
    }
}
