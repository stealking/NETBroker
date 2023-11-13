using System.ComponentModel.DataAnnotations;

namespace Core.Models.Requests.Suppliers
{
    public class SupplierUpdateRequest : IRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Maximum length for the Name is 100 characters.")]
        public string? Name { get; set; }
    }
}
