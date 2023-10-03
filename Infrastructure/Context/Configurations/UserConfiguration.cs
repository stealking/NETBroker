using Core.Entities;
using Core.Entities.Enums;
using Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasData
                (
                    new UserProfile(1, "admin", "Admin", StringExtensions.HashPassword("123456"), UserTypes.Admin, "", null, ""),
                    new UserProfile(2, "user", "User", StringExtensions.HashPassword("123456"), UserTypes.User, "", null, ""),
                    new UserProfile(3, "partner", "Partner", StringExtensions.HashPassword("123456"), UserTypes.Partner, "", null, "")
                );
        }
    }
}
