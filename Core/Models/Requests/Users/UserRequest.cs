using System.ComponentModel.DataAnnotations;

namespace Core.Models.Requests.Users
{
    public class UserRequest
    {
        public int Id { get; set; }

        [Required]
        public string? UserName { get; init; }

        [Required]
        [MinLength(6)]
        public string? Password { get; init; }

        [Required]
        public string? FullName { get; init; }

        public string? Address { get; init; }
        public DateTime? BirthDay { get; init; }

        public string? Email { get; init; }

        [Phone(ErrorMessage = "Invalid phone number")]
        public string? PhoneNumber { get; init; }
        public ICollection<string>? Roles { get; init; }
    }
}
