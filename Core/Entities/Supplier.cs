using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Supplier : BaseCreateTable
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "")]
        [MaxLength(100, ErrorMessage = "Maximum length for the Name is 100 characters.")]
        public string? Name { get; set; }

        private Supplier()
        {
            
        }

        public Supplier(int id, string? name, int creator)
        {
            Id = id;
            Name = name;
            Creator = creator;
        }

        public Supplier(int id, string? name, int creator, DateTime dateCreated, bool isActive)
        {
            Id = id;
            Name = name;
            Creator = creator;
            DateCreated  = dateCreated;
            IsActive = isActive;
        }

        public ICollection<Deposit>? Deposits { get; set; }
        public ICollection<Contract>? Contracts { get; set; }
    }
}
