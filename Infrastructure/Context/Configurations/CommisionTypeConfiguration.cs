using Core.Entities;
using Core.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class CommisionTypeConfiguration : IEntityTypeConfiguration<CommisionType>
    {
        public void Configure(EntityTypeBuilder<CommisionType> builder)
        {
            builder.HasData(
                new CommisionType(1, 1, 1, 1, ProgramAdderType.Override, 0.007, 0.5m),
                new CommisionType(2, 1, 2, 2, ProgramAdderType.Override, 0.007, 0.5m),
                new CommisionType(3, 2, 3, 3, ProgramAdderType.Override, 0.007, 0m)
            );
        }
    }
}
