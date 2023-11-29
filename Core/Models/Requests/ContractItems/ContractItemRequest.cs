using Core.Entities;
using Core.Entities.Enums;
using Core.Models.Requests.ContractItemAttachments;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.Requests.ContractItems
{
    public class ContractItemRequest : IRequest
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int ContractId { get; set; }
        [Required]
        public string? UtilityAccountNumber { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public int? TermMonth { get; set; }
        [Required]
        public ProductTypes? ProductType { get; set; }
        [Required]
        public EnergyUnitTypes? EnergyUnitType { get; set; }
        public int? AnnualUsage { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Adder { get; set; }

        public ICollection<ContractItemAttachmentRequest> ContractItemAttachments { get; set; } = new List<ContractItemAttachmentRequest>();
        public List<ContractItemForecast> ContractItemForecasts { get; set; } = new List<ContractItemForecast>();
    }
}
