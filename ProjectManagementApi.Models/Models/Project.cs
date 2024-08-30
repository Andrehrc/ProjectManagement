using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApi.Models.Models
{
    public class Project
    {
        public int Id { get; set; }

        [DisplayName("Project")]
        public string Name { get; set; }

        [DisplayName("Version")]
        public string Version { get; set; }

        [DisplayName("Programming Language")]
        public string ProgrammingLanguage { get; set; }

        [DisplayName("Last Certification")]
        public DateTime? LastCertification { get; set; }

        public List<DevelopmentStage>? Stages { get; set; }

        public virtual Employee Employee { get; set; }  
    }
    public static class DbContextProject
    {
        public static void ConfigureProjectDevelopmentStages(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasMany(p => p.Stages) 
                .WithOne() 
                .HasForeignKey(ds => ds.ProjectId) 
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
