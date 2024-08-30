using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApi.Models.Models
{
    public class UserRefreshToken
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public string RefreshToken { get; set; }

        public DateTime Expiration { get; set; }

        public virtual User User { get; set; }
    }
}
