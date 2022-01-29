using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fajn.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        [Required]
        public string EventName { get; set; } = string.Empty;
        public string StartingDate { get; set; }= string.Empty;
        public string EndingDate { get; set; } = string.Empty;
        public ICollection<Game> Games { get; set; }
        public ICollection<AllGames> AllGames { get; set; }
    }
}
