using Core.Entities;
using Core.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class DateConfigConfiguration : IEntityTypeConfiguration<DateConfig>
    {
        public void Configure(EntityTypeBuilder<DateConfig> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.HasMany(p => p.CommisionTypes)
                .WithOne(p => p.DateConfig)
                .HasForeignKey(p => p.DateConfigId)
                .HasPrincipalKey(p => p.Id);

            builder.HasData(
                new DateConfig(1, "SoldDate", "NoModifier", ControlDateOffsetType.DayOfWeek_Fridays, 2m),
                new DateConfig(2, "SoldDate", "NoModifier", ControlDateOffsetType.NoOffset, 2m),
                new DateConfig(3, "SoldDate", "NoModifier", ControlDateOffsetType.NoOffset, 2m)
                );
        }
    }
}
