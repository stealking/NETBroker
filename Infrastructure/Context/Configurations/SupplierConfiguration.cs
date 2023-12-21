using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasMany(p => p.Contracts)
                .WithOne(p => p.Supplier)
                .HasForeignKey(p => p.SupplierId)
                .HasPrincipalKey(p => p.Id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.Deposits)
                .WithOne(p => p.Supplier)
                .HasForeignKey(p => p.SupplierId)
                .HasPrincipalKey(p => p.Id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Supplier(1, "IGS", 1),
                new Supplier(2, "TTS", 1)
            );
        }
    }
}
