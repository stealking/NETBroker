using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class SaleProgramConfiguration : IEntityTypeConfiguration<SaleProgram>
    {
        public void Configure(EntityTypeBuilder<SaleProgram> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasData(
                new SaleProgram(1, "KWH", "50% contract upfront then residual", "PercentageContractUpfront + PercentageContractResidual"),
                new SaleProgram(2, "THM", "Forecast annual margin divided by four", "QuarterlyUpfront")
            );
        }
    }
}
