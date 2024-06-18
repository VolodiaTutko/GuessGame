using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame.Data.Models
{
    public partial class Word
    {
        [Key]
        public int? WordId { get; set; }

        [MaxLength(30)]
        public string? Value { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }
    }
}
