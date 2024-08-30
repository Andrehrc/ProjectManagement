using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApi.Models.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public string TechnicalExperienceLevel { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string ImagePath { get; set; } = string.Empty;

        public virtual Project Project { get; set; }
    }

    public static class DbContextColaboradores
    {
        public static void ConfigureEmployeeProject(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Project) 
                .WithOne(p => p.Employee)  
                .HasForeignKey<Employee>(e => e.ProjectId)  
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
