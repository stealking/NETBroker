using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class QualificationConfiguration : IEntityTypeConfiguration<Qualification>
    {
        public void Configure(EntityTypeBuilder<Qualification> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(p => p.SalesProgramId)
                    .IsRequired();

        }
    }
}
