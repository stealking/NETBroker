using Core.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.Requests.Users
{
    public class UserRegisterRequest
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? FullName { get; set; }

        [Required]
        public UserTypes? UserType { get; set; }

        public string? Address { get; set; }
        public DateTime? BirthDay { get; set; }

        [Phone(ErrorMessage = "Invalid phone number")]
        public string? Phone { get; set; }
    }
}
