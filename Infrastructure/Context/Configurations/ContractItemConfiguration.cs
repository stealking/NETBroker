using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class ContractItemConfiguration : IEntityTypeConfiguration<ContractItem>
    {
        public void Configure(EntityTypeBuilder<ContractItem> builder)
        {
            builder.HasData(
                new ContractItem(1, 1, "9138014006", new DateTime(2023, 04, 14), new DateTime(2025, 04, 13), 24, "Elec", "KWH", 58398, (decimal)0.01275, (decimal)0.0075, 1),
                new ContractItem(2, 1, "9138014006", new DateTime(2023, 03, 20), new DateTime(2024, 07, 19), 16, "Gas", "CCF", 12303, (decimal)0.2275, (decimal)0.073, 1),
                new ContractItem(3, 1, "9138014006", new DateTime(2023, 04, 20), new DateTime(2024, 04, 19), 12, "Elec", "MWH", 835, (decimal)23, (decimal)6.3, 1),
                new ContractItem(4, 1, "9138014006", new DateTime(2023, 05, 13), new DateTime(2024, 08, 12), 15, "Elec", "KWH", 160880, (decimal)0.02275, (decimal)0.0073, 1),
                new ContractItem(5, 1, "9138014006", new DateTime(2023, 06, 20), new DateTime(2024, 06, 19), 12, "Gas", "THM", 89340, (decimal)0.3275, (decimal)0.083, 1),
                new ContractItem(6, 2, "177478640021", new DateTime(2023, 02, 20), new DateTime(2024, 07, 19), 17, "Elec", "KWH", 36000, (decimal)0.0225, (decimal)0.003, 1),
                new ContractItem(7, 2, "177478640021", new DateTime(2023, 01, 28), new DateTime(2024, 03, 27), 14, "Gas", "MCF", 4200, (decimal)2.275, (decimal)0.073, 1),
                new ContractItem(8, 2, "177478640021", new DateTime(2023, 04, 10), new DateTime(2024, 08, 09), 16, "Elec", "MWH", 1500, (decimal)20.75, (decimal)5.32, 1),
                new ContractItem(9, 2, "177478640021", new DateTime(2023, 02, 23), new DateTime(2024, 08, 22), 18, "Gas", "CCF", 60000, (decimal)0.1275, (decimal)0.053, 1),
                new ContractItem(10, 2, "177478640021", new DateTime(2023, 03, 05), new DateTime(2024, 06, 04), 15, "Elec", "KWH", 15000, (decimal)0.04275, (decimal)0.0033, 1)
            );
        }
    }
}
