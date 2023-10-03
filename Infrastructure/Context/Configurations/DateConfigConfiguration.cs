using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class DateConfigConfiguration : IEntityTypeConfiguration<DateConfig>
    {
        public void Configure(EntityTypeBuilder<DateConfig> builder)
        {
        }
    }
}
