using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Contact : BaseCreateTable
    {
        private Contact() { }

        public Contact(int id, string? name, int creator, DateTime dateCreated, bool isActive)
        {
            Id = id;
            Name = name;
            Creator = creator;
            DateCreated = dateCreated;
            IsActive = isActive;
        }

        public Contact(int id, string? name, int creator)
        {
            Id = id;
            Name = name;
            Creator = creator;
        }

        [Key]
        public int Id { get; init; }

        [Required(ErrorMessage = "Name is required field.")]
        [MaxLength(100, ErrorMessage = "Maximum length for the Name is 100 characters.")]
        public string? Name { get; set; }


        public ICollection<Contract>? Contracts { get; set; }
    }
}
