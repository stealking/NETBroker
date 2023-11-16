using Core.Entities.Enums;

namespace Core.Models.Response.ContractItems
{
    public class ContractItemResponse
    {
        public int Id { get; set; }
        public string? UtilityAccountNumber { get; set; }
        public int TermMonth { get; set; }
        public ProductTypes? ProductType { get; set; }
        public EnergyUnitTypes? EnergyUnitType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? AnnualUsage { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Adder { get; set; }
    }
}
