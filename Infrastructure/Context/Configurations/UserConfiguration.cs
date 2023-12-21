using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasMany(p => p.CloserContracts)
                .WithOne(p => p.Closer)
                .HasForeignKey(p => p.CloserId)
                .HasPrincipalKey(p => p.Id);

            builder.HasMany(p => p.FronterContracts)
               .WithOne(p => p.Fronter)
               .HasForeignKey(p => p.FronterId)
               .HasPrincipalKey(p => p.Id);

            builder.HasData(
                new UserProfile(1, "admin", "Admin", "admin@example.com", null, null, null, null),
                new UserProfile(2, "user", "User", "user@example.com", null, null, null, null)
                );
        }
    }
}
