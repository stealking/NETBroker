﻿using Core.Entities;
using Core.Models.Requests.Users;

namespace Core.Services
{
    public interface IUserService : IServiceBase<UserProfile>
    {
        Task<UserProfile?> Autheticate(UserLoginRequest request);
        Task<UserProfile?> GetByUserName(string? userName);
        Task<UserProfile?> GetById(int id);
    }
}
