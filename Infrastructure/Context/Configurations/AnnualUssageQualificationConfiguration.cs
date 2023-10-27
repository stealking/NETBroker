using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    internal class AnnualUssageQualificationConfiguration : IEntityTypeConfiguration<AnnualUssageQualification>
    {
        public void Configure(EntityTypeBuilder<AnnualUssageQualification> builder)
        {
            builder.Property(p => p.FromAnnualUsage)
                .IsRequired();

            builder.Property(p => p.ToAnnualUsage)
                .IsRequired();

            builder.HasData(
                new AnnualUssageQualification(3, 2, 50000, 100000)
                );
        }
    }
}
