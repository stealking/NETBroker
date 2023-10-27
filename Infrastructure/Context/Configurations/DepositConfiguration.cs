using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class DepositConfiguration : IEntityTypeConfiguration<Deposit>
    {
        public void Configure(EntityTypeBuilder<Deposit> builder)
        {
            builder.HasOne(p => p.Supplier)
                .WithMany(p => p.Deposits)
                .HasForeignKey(p => p.SupplierId)
                .HasPrincipalKey(p => p.Id)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasData(
               new Deposit(1, 1, new DateTime(2023, 09, 14), 156.34m),
               new Deposit(2, 1, new DateTime(2023, 11, 27), 19.25m),
               new Deposit(3, 1, new DateTime(2023, 07, 29), 8.75m)
           );
        }
    }
}
