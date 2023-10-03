using Core.Entities;
using Core.Extensions;
using Core.Models.Requests.Users;
using Core.Repositories;
using Core.Services;

namespace Domain.Services
{
    public sealed class UserService : IUserService
    {
        private IRepositoryManager repositoryManager;
        public UserService(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }

        public async Task<UserProfile?> Autheticate(UserLoginRequest request)
        {
            var user = (await repositoryManager.User.FindByConditionAsync(x => x.UserName == request.UserName && x.IsActive)).OfType<UserProfile>().FirstOrDefault();
            return user == null || !StringExtensions.VerifyHashedPassword(user.PasswordHash, request.Password) ? null : user;
        }

        public async Task<UserProfile> Create(UserProfile user)
        {
            var result = await repositoryManager.User.CreateAsync(user);
            await repositoryManager.SaveAsync();
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            var user = (await repositoryManager.User.FindByConditionAsync(x => x.Id == id)).FirstOrDefault();
            if (user != null)
            { 
                user.IsActive = false;
                await Update(user);
                return true;
            }
            return false;
        }

        public async Task<List<UserProfile>> GetAll()
        {
            var users = (await repositoryManager.User.FindByConditionAsync(x => x.IsActive)).OfType<UserProfile>().ToList();
            return users;
        }

        public async Task<UserProfile?> GetById(int id)
        {
            return (await repositoryManager.User.FindByConditionAsync(x => x.Id == id && x.IsActive)).FirstOrDefault();
        }

        public async Task<UserProfile?> GetByUserName(string? userName)
        {
            return (await repositoryManager.User.FindByConditionAsync(x => x.UserName ==  userName)).FirstOrDefault();
        }

        public async Task Update(UserProfile user)
        {
            await repositoryManager.User.UpdateAsync(user);
            await repositoryManager.SaveAsync();
        }
    }
}
