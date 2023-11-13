using Core.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.Requests.Contracts
{
    public class ContractUpdateRequest : IRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? LegalEntityName { get; set; }

        public DateTime? SoldDate { get; set; }

        [Required]
        public int? SupplierId { get; set; }

        [Required]
        public int? ContactId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public Stage Stage { get; set; }
    }
}
