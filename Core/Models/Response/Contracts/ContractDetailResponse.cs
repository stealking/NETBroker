using Core.Models.Response.ContractItems;

namespace Core.Models.Response.Contracts
{
    public class ContractDetailResponse
    {
        public int Id { get; set; }
        public string? LegalEntityName { get; set; }
        public DateTime SoldDate { get; set; }
        public string? BillingChargeType { get; set; }
        public string? BillingType { get; set; }
        public string? EnrollmentType { get; set; }
        public string? PricingType { get; set; }
        public int? SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public int? ContactId { get; set; }
        public string? ContactName { get; set; }
        public int? CloserId { get; set; }
        public string? CloserName { get; set; }
        public int FronterId { get; set; }
        public string? FronterName { get; set; }
        public int? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public ICollection<ContractItemResponse> ContractItems { get; set; } = new  List<ContractItemResponse>();
    }
}
