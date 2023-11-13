using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Entities;
using Core.Models.Requests.Users;
using Core.Models.Response.Users;
using Core.Repositories;
using Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public sealed class UserService : IUserService
    {
        private IRepositoryManager repositoryManager;
        private UserManager<UserProfile> userManager;
        private readonly IMapper mapper;

        public UserService(IRepositoryManager repositoryManager, UserManager<UserProfile> userManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.userManager = userManager;
            this.mapper = mapper;
        }

        public async Task<bool> Create(UserRequest request)
        {
            var user = mapper.Map<UserProfile>(request);
            var result = await repositoryManager.User.CreateAsync(user);
            await repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var user = await repositoryManager.User.FindById(id);
            if (user != null)
            { 
                user.IsActive = false;
                await repositoryManager.User.UpdateAsync(user);
                await repositoryManager.SaveAsync();
                return true;
            }
            return false;
        }

        public async Task<List<UserResponse>> GetAll(UserParameters userParameters)
        {
            var users = await repositoryManager.User.FindByCondition(x => x.IsActive)
                .Skip(userParameters.Skip)
                .Take(userParameters.PageSize)
                .ProjectTo<UserResponse>(mapper.ConfigurationProvider)
                .ToListAsync();
            return users;
        }

        public async Task<UserResponse?> GetById(object id)
        {
            var user = await userManager.FindByIdAsync(id.ToString() ?? "0");
            if (user != null)
            {
                user.Roles = await userManager.GetRolesAsync(user);
            }
            return mapper.Map<UserResponse>(user);
        }

        public async Task Update(UserRequest request)
        {
            var user = await userManager.FindByIdAsync(request.Id.ToString() ?? "0");
            if (user == null)
            {
                throw new ArgumentNullException("User not found.");
            }

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
    }
}
