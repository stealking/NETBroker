using Core.Entities.Enums;

namespace Core.Models.Response.ContractItems
{
    public class ContractItemResponse
    {
        public int Id { get; set; }
        public int? UtilityAccountNumber { get; set; }
        public int TermMonth { get; set; }
        public ProductType? ProductType { get; set; }
        public EnergyUnitType? EnergyUnitType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal? AnnualUsage { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Adder { get; set; }
    }
}
