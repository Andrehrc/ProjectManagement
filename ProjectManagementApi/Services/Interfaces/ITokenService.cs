using Microsoft.IdentityModel.Tokens;
using ProjectManagementApi.Models.Models;
using ProjectManagementApi.Models.Utils;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace ProjectManagementApi.Services.Interfaces
{
    public interface ITokenService
    {
        Task<string> GenerateToken(string userId);
        Task<User> ValidateUserAsync(string email, string password);
        Task<string> RefreshTokenAsync(string currentRefreshToken, int userId);
        Task<string> GenerateRefreshTokenAsync(int userId);
        Task DeleteRefreshTokenAsync(string refreshToken);
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
