using Core.Models.Requests.Users;
using Core.Models.Response.Users;

namespace Core.Services
{
    public interface IUserService : IServiceBase<UserResponse, UserRequest, UserParameters>
    {
        Task<bool> ChangeUserPassword(ChangeUserPasswordRequest request);
    }
}
