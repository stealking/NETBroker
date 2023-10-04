using Core.Entities;
using System.Security.Claims;

namespace Core.Services
{
    public interface IAuthenticationService
    {
        string CreateToken(UserProfile user);
        ClaimsPrincipal? ValidateToken(string token);
    }
}
