using Core.Entities;
using Core.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class ContractItemConfiguration : IEntityTypeConfiguration<ContractItem>
    {
        public void Configure(EntityTypeBuilder<ContractItem> builder)
        {
            builder.HasData(
                new ContractItem(1, 1, "9138014006", new DateTime(2023, 04, 14), 24, ProductType.Elec, EnergyUnitType.KWH, 58398, (decimal)0.01275, (decimal)0.0075, 1),
                new ContractItem(2, 1, "9138014006", new DateTime(2023, 03, 20), 16, ProductType.Gas, EnergyUnitType.CCF, 12303, (decimal)0.2275, (decimal)0.073, 2),
                new ContractItem(3, 1, "9138014006", new DateTime(2023, 04, 20), 12, ProductType.Elec, EnergyUnitType.MWH, 835, (decimal)23, (decimal)6.3, 3),
                new ContractItem(4, 1, "9138014006", new DateTime(2023, 05, 13), 15, ProductType.Elec, EnergyUnitType.KWH, 160880, (decimal)0.02275, (decimal)0.0073, 4),
                new ContractItem(5, 1, "9138014006", new DateTime(2023, 06, 20), 12, ProductType.Gas, EnergyUnitType.THM, 89340, (decimal)0.3275, (decimal)0.083, 5),
                new ContractItem(6, 2, "177478640021", new DateTime(2023, 02, 20), 17, ProductType.Elec, EnergyUnitType.KWH, 36000, (decimal)0.0225, (decimal)0.003, 1),
                new ContractItem(7, 2, "177478640021", new DateTime(2023, 01, 28), 14, ProductType.Gas, EnergyUnitType.MCF, 4200, (decimal)2.275, (decimal)0.073, 1),
                new ContractItem(8, 2, "177478640021", new DateTime(2023, 04, 10), 16, ProductType.Elec, EnergyUnitType.MWH, 1500, (decimal)20.75, (decimal)5.32, 1),
                new ContractItem(9, 2, "177478640021", new DateTime(2023, 02, 23), 18, ProductType.Gas, EnergyUnitType.CCF, 60000, (decimal)0.1275, (decimal)0.053, 1),
                new ContractItem(10, 2, "177478640021", new DateTime(2023, 03, 05), 15, ProductType.Elec, EnergyUnitType.KWH, 15000, (decimal)0.04275, (decimal)0.0033, 1)
            );
        }
    }
}
