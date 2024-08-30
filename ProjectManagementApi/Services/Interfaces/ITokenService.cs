namespace ProjectManagementApi.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(string userId);

    }
}
