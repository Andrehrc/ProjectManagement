using Microsoft.EntityFrameworkCore;
using ProjectManagementApi.Contexts;
using ProjectManagementApi.Models.Models;
using ProjectManagementApi.Repositories.Interfaces;

namespace ProjectManagementApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public User ValidateUser(string email, string password)
        {
            return _context.Users.SingleOrDefault(user =>
                user.Email == email && user.Password == password);
        }
    }
}
