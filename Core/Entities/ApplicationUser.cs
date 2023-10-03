using Core.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public abstract class ApplicationUser
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [MaxLength(50, ErrorMessage = "Maximum length for the username is 50 characters")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        [MaxLength(255, ErrorMessage = "Maximum length for the full name is 255 characters")]
        public string? FullName { get; set; }

        [Required]
        public string? PasswordHash { get; set; }

        [Required]
        public UserTypes UserType { get; set; }

        public bool IsActive { get; set; } = true;
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }

    public class UserProfile : ApplicationUser
    {
        public UserProfile()
        {

        }
        public UserProfile(int id, string? userName, string? fullName, string? passwordHash, UserTypes userType, string? address, DateTime? birthDay, string? phone, bool isActive = true)
        {
            Id = id;
            UserName = userName;
            FullName = fullName;
            PasswordHash = passwordHash;
            UserType = userType;
            Address = address;
            BirthDay = birthDay;
            Phone = phone;
            IsActive = isActive;
        }

        [MaxLength(255, ErrorMessage = "Maximum length for the full name is 255 characters")]
        public string? Address { get; set; }
        public DateTime? BirthDay { get; set; }

        [Phone(ErrorMessage = "Invalid phone number")]
        public string? Phone { get; set; }

        public ICollection<Contract>? Contracts { get; set; }
    }
}
