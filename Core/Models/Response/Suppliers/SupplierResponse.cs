using Core.Models.Response.Users;

namespace Core.Models.Response.Suppliers
{
    public class SupplierResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Creator { get; set; }
        public UserResponse? CreatorInfo { get; set; }
    }
}
