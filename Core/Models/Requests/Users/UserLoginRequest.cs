using System.ComponentModel.DataAnnotations;

namespace Core.Models.Requests.Users
{
    public class UserLoginRequest
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
