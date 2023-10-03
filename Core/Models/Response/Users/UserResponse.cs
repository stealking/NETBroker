using Core.Entities.Enums;

namespace Core.Models.Response.Users
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? BirthDate { get; set; }
        public UserTypes Type { get; set; }
        public string TypeName => Type.ToString();
    }
}
