using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class CommisionTypeConfiguration : IEntityTypeConfiguration<CommisionType>
    {
        public void Configure(EntityTypeBuilder<CommisionType> builder)
        {
            builder.HasOne(p => p.SaleProgram)
                .WithMany(p => p.CommisionTypes)
                .HasForeignKey(p => p.SalesProgramId)
                .HasPrincipalKey(p => p.Id);

            builder.HasData(
                new CommisionType(1, 1, "ContractUpfront", "Override", 0.007, "0.5"),
                new CommisionType(2, 1, "PercentageContractResidual", "Override", 0.007, "0.5"),
                new CommisionType(3, 2, "QuarterlyUpfront", "Override", 0.007, "x")
            );
        }
    }
}
