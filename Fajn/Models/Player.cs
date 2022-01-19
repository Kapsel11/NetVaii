using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fajn.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Title { get; set; } = string.Empty;
        [Required]
        public int Age { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public int Elo { get; set; }

    }
}
