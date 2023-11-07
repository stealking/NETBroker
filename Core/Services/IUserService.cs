using Core.Entities;
using Core.Models.Requests.Users;

namespace Core.Services
{
    public interface IUserService : IServiceBase<UserProfile>
    {
        Task<List<UserProfile>> GetUsersAsync(UserParameters userParameters);
        Task<UserProfile?> GetByUserName(string? userName);
        Task<UserProfile?> GetById(int id);
        Task<bool> ChangeUserPassword(ChangeUserPasswordRequest request);
    }
}
