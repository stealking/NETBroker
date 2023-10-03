using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasMany(p => p.Contracts)
                .WithOne(p => p.Customer)
                .HasForeignKey(p => p.CustomerId)
                .HasPrincipalKey(p => p.Id);

            builder.HasData(
                new Customer(1, "Customer 1", 1),
                new Customer(2, "Customer 2", 1),
                new Customer(3, "Customer 3", 2),
                new Customer(4, "Customer 4", 2),
                new Customer(5, "Customer 5", 3)
                );
        }
    }
}
