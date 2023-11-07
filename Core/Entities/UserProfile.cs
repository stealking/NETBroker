using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class UserProfile : IdentityUser<int>
    {
        public UserProfile()
        {

        }
        public UserProfile(int id, string? userName, string? fullName, string email, string? passwordHash, string? address, DateTime? birthDay, string? phone, bool isActive = true)
        {
            Id = id;
            UserName = userName;
            FullName = fullName;
            PasswordHash = passwordHash;
            Email = email;
            Address = address;
            BirthDay = birthDay;
            PhoneNumber = phone;
            IsActive = isActive;
            EmailConfirmed = true;
            PhoneNumberConfirmed = true;
            NormalizedEmail = email.ToUpper();
            NormalizedUserName = userName?.ToUpper();
        }

        [MaxLength(255, ErrorMessage = "Maximum length for the full name is 255 characters")]
        public string? Address { get; set; }
        public DateTime? BirthDay { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        [MaxLength(255, ErrorMessage = "Maximum length for the full name is 255 characters")]
        public string? FullName { get; set; }

        public bool IsActive { get; set; } = true;
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public ICollection<Contract>? CloserContracts { get; set; }
        public ICollection<Contract>? FronterContracts { get; set; }
        public Supplier? SupplierCreator { get; set; }

        [NotMapped]
        public ICollection<string>? Roles { get; set; }
    }
}
