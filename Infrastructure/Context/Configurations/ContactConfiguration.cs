using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasMany(p => p.Contracts)
                .WithOne(p => p.Contact)
                .HasForeignKey(p => p.ContactId)
                .HasPrincipalKey(p => p.Id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Contact(1, "Contact 1", 1),
                new Contact(2, "Contact 2", 1),
                new Contact(3, "Contact 3", 1),
                new Contact(4, "Contact 4", 1),
                new Contact(5, "Contact 5", 1)
            );
        }
    }
}
