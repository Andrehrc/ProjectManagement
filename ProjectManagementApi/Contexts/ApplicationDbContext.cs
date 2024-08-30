using Microsoft.EntityFrameworkCore;
using ProjectManagementApi.Models.Models;

namespace ProjectManagementApi.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.SetarConfigRecado();
            modelBuilder.Seed();
        }
    }

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User {
                    Id = 1,
                    Username = "User1",
                    Email ="user1email@test.com",
                    Password = "teste",
                    ConfirmationToken = Guid.NewGuid().ToString(),
                    EmailConfirmed = false
                },
                new User
                {
                    Id = 2,
                    Username = "User2",
                    Email ="user2email@test.com",
                    Password = "teste",
                    ConfirmationToken = Guid.NewGuid().ToString(),
                    EmailConfirmed = false
                }
            });
        }
    }

}
