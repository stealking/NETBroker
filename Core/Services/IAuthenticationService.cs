using Core.Entities;
using Core.Models.Requests.Users;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Core.Services
{
    public interface IAuthenticationService
    {
        Task<UserProfile?> Autheticate(UserLoginRequest request);
        Task<IdentityResult> RegisterUser(UserRegisterRequest user);
        Task<string> CreateToken(UserProfile user);
        ClaimsPrincipal? ValidateToken(string token);
    }
}
