using ProjectManagementApi.Models.Models;

namespace ProjectManagementApi.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User ValidateUser(string email, string password);
    }
}
