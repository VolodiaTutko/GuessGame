using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame.Data.Models
{
    public partial class User
    {
        [Key]
        public int? UserId { get; set; }

        [MaxLength(20)]
        public string? Name { get; set; }

        [MaxLength(20)]
        public string? Password { get; set; }

        public int? Score { get; set; }
    }
}
