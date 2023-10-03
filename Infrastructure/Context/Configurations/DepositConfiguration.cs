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
               new Deposit(1, 1, new DateTime(2023, 09, 14), (decimal)156.34),
               new Deposit(2, 1, new DateTime(2023, 11, 27), (decimal)19.25),
               new Deposit(3, 1, new DateTime(2023, 07, 29), (decimal)8.75)
           );
        }
    }
}
