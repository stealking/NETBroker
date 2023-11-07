using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class BaseCreateTable
    {
        [Required(ErrorMessage = "Creator is required field.")]
        public int? Creator { get; set; }

        [Required(ErrorMessage = "DateCreated is required field.")]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "IsActive is required field.")]
        public bool IsActive { get; set; } = true;

        public UserProfile? CreatorInfo { get; set; }
    }
}
