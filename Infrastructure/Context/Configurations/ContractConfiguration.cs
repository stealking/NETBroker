using Core.Entities;
using Core.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasMany(p => p.ContractItems)
                .WithOne(p => p.Contract)
                .HasForeignKey(p => p.ContractId)
                .HasPrincipalKey(p => p.Id)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasData(
                new Contract(1, 1, "John A", 1, 1, 1, 1, new DateTime(2023, 03, 14), BillingChargeTypes.AllIn, BillingTypes.ChickenRanch, EnrollmentTypes.TPV, PricingTypes.Matrix, 1),
                new Contract(2, 2, "John B", 2, 2, 2, 2, new DateTime(2023, 01, 20), BillingChargeTypes.AllIn, BillingTypes.ChickenRanch, EnrollmentTypes.TPV, PricingTypes.Matrix, 2)
                );
        }
    }
}
