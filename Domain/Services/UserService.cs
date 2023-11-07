using Core.Entities;
using Core.Models.Requests;
using Core.Models.Requests.Users;
using Core.Repositories;
using Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Domain.Services
{
    public sealed class UserService : IUserService
    {
        private IRepositoryManager repositoryManager;
        private UserManager<UserProfile> userManager;

        public UserService(IRepositoryManager repositoryManager, UserManager<UserProfile> userManager)
        {
            this.repositoryManager = repositoryManager;
            this.userManager = userManager;
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
            var users = await repositoryManager.User.FindByCondition(x => x.IsActive).ToListAsync();
            return users;
        }

        public async Task<UserProfile?> GetById(int id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            if (user != null)
            {
                user.Roles = await userManager.GetRolesAsync(user);
            }
            return user;
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

        public async Task<bool> ChangeUserPassword(ChangeUserPasswordRequest request)
        {
            var user = await userManager.FindByIdAsync(request.UserId.ToString());
            if (user == null) return false;

            var result = await userManager.ChangePasswordAsync(user, request.OldPassword ?? "", request.NewPassword ?? "");
            return result.Succeeded;
        }

        public async Task<List<UserProfile>> GetUsersAsync(UserParameters userParameters)
        {
            var users = await repositoryManager.User.FindByCondition(x => x.IsActive)
                .Skip(userParameters.Skip)
                .Take(userParameters.PageSize)
                .ToListAsync();
            return users;
        }
    }
}
