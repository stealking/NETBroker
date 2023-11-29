using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class ContractItemForecastConfiguration : IEntityTypeConfiguration<ContractItemForecast>
    {
        public void Configure(EntityTypeBuilder<ContractItemForecast> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ContractItemId).IsRequired();
            builder.Property(x => x.ForecastMonth).IsRequired();
            builder.Property(x => x.Amount).IsRequired();
        }
    }
}
