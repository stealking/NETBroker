using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class CommissionConfigurationTypeConfiguration : IEntityTypeConfiguration<CommissionConfigurationType>
    {
        public void Configure(EntityTypeBuilder<CommissionConfigurationType> builder)
        {

            builder.HasMany(p => p.CommisionTypes)
                .WithOne(p => p.CommissionConfigurationType)
                .HasForeignKey(p => p.CommissionConfigurationTypeId)
                .HasPrincipalKey(p => p.Id);

            builder.HasData(
                new CommissionConfigurationType(1, "ContractUpfront"),
                new CommissionConfigurationType(2, "PercentageContractResidual"),
                new CommissionConfigurationType(3, "QuarterlyUpfront")
                );
        }
    }
}
