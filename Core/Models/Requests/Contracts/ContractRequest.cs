using Core.Entities.Enums;
using Core.Models.Requests.ContractItems;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.Requests.Contracts
{
    public class ContractRequest : IRequest
    {
        [Required]
        public string? LegalEntityName { get; set; }

        public DateTime? SoldDate { get; set; }

        [Required]
        public BillingChargeTypes BillingChargeType { get; set; }

        [Required]
        public BillingTypes BillingType { get; set; }

        [Required]
        public EnrollmentTypes EnrollmentType { get; set; }

        [Required]
        public PricingTypes PricingType { get; set; }

        [Required]
        public int? SupplierId { get; set; }

        [Required]
        public int? ContactId { get; set; }

        public int? CloserId { get; set; }

        public int? FronterId { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Stage Stage { get; set; } = Stage.Opportunity;
        public ICollection<ContractItemRequest> ContractItemRequests { get; set; } = new List<ContractItemRequest>();
    }
}
