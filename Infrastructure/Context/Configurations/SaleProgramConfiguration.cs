using Core.Entities;
using Core.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class SaleProgramConfiguration : IEntityTypeConfiguration<SaleProgram>
    {
        public void Configure(EntityTypeBuilder<SaleProgram> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasMany(p => p.CommisionTypes)
              .WithOne(p => p.SaleProgram)
              .HasForeignKey(p => p.SalesProgramId)
              .HasPrincipalKey(p => p.Id);

            builder.HasMany(p => p.Qualifications)
                .WithOne(p => p.SaleProgram)
                .HasForeignKey(p => p.SalesProgramId)
                .HasPrincipalKey(p => p.Id);

            builder.HasData(
                new SaleProgram(1, EnergyUnitTypes.KWH, "50% contract upfront then residual", "PercentageContractUpfront + PercentageContractResidual"),
                new SaleProgram(2, EnergyUnitTypes.THM, "Forecast annual margin divided by four", "QuarterlyUpfront")
            );
        }
    }
}
