using System.ComponentModel.DataAnnotations;

namespace Core.Models.Requests.Suppliers
{
    public class SupplierRequest : IRequest
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Maximum length for the Name is 100 characters.")]
        public string? Name { get; set; }

        [Required]
        public int? Creator { get; set; }
    }
}
