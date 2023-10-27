using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class ExpirationQualificationConfiguration : IEntityTypeConfiguration<ExpirationQualification>
    {
        public void Configure(EntityTypeBuilder<ExpirationQualification> builder)
        {
            builder.Property(p => p.EffectiveDate)
                .IsRequired();

            builder.Property(p => p.ExpiryDate)
                .IsRequired();

            builder.HasData(
                new ExpirationQualification(1, 1, new DateTime(2023, 05, 01), new DateTime(2030, 05, 01)),
                new ExpirationQualification(2, 2, new DateTime(2023, 05, 01), new DateTime(2099, 05, 01))
                );
        }
    }
}
