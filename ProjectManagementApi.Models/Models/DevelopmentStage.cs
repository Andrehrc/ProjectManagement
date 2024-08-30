﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApi.Models.Models
{
    public class DevelopmentStage
    {
        public int Id { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }

        [DisplayName("Development Stage")]
        public string DevelopmentStageName { get; set; }

        [DisplayName("Development Percentage")]
        [Precision(10, 2)]
        public decimal DevelopmentPercentage { get; set; }

        [NotMapped]
        public bool Delete { get; set; } = false;
    }
}
