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

            builder.HasData(
                new DateConfig(1, 1, ControlDateTypes.SoldDate, ControlDateModifierTypes.NoModifier, ControlDateOffsetType.DayOfWeek_Fridays, 2),
                new DateConfig(2, 2, ControlDateTypes.SoldDate, ControlDateModifierTypes.NoModifier, ControlDateOffsetType.NoOffset, 0),
                new DateConfig(3, 3, ControlDateTypes.SoldDate, ControlDateModifierTypes.NoModifier, ControlDateOffsetType.NoOffset, 0)
                );
        }
    }
}
