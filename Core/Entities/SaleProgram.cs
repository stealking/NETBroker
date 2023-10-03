namespace Core.Entities
{
    public class SaleProgram
    {
        public SaleProgram()
        {
        }

        public SaleProgram(int id, string? energyUnitType, string? description, string? salesProgramType)
        {
            Id = id;
            EnergyUnitType = energyUnitType;
            Description = description;
            SalesProgramType = salesProgramType;
        }

        public int Id { get; set; }
        public string? EnergyUnitType { get; set; }
        public string? Description { get; set; }
        public string? SalesProgramType { get; set; }
        public ICollection<CommisionType>? CommisionTypes { get; set; }
    }
}
