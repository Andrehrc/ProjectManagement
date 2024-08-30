using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApi.Models.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Guid ConfirmationToken { get; set; }

        public bool EmailConfirmed { get; set; }

        public virtual UserRefreshToken RefreshToken { get; set; }
    }

    public static class DbContextUser
    {
        public static void ConfigureUserRefreshToken(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.RefreshToken) 
                .WithOne(rt => rt.User) 
                .HasForeignKey<UserRefreshToken>(rt => rt.UserId) 
                .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}
