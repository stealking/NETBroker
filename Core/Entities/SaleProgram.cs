using Core.Entities.Enums;

namespace Core.Entities
{
    public class SaleProgram
    {
        public SaleProgram()
        {
        }

        public SaleProgram(int id, EnergyUnitTypes energyUnitType, string? description, string? salesProgramType)
        {
            Id = id;
            EnergyUnitType = energyUnitType;
            Description = description;
            SalesProgramType = salesProgramType;
        }

        public int Id { get; init; }
        public EnergyUnitTypes EnergyUnitType { get; set; }
        public string? Description { get; set; }
        public string? SalesProgramType { get; set; }
        public ICollection<CommisionType> CommisionTypes { get; set; } = new List<CommisionType>();
        public ICollection<Qualification> Qualifications { get; set; } = new List<Qualification>();
        public ICollection<ContractItemForecast>? ContractItemForecasts { get; set; }

        public int? ContractItemId { get; set; }
        public ContractItem? ContractItem { get; set; }
    }
}
