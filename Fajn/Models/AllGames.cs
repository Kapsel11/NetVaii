using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Fajn.Models
{
    public class AllGames
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public string White { get; set; }
        [Required]
        public string Black { get; set; }
        [Required]
        public string Result { get; set; }
        public string Date { get; set; }
        public int? EventId { get; set; }
        [ForeignKey("EventId")]
        public Event Event { get; set; }
        [Required]
        public string Pgn { get; set; }

    }
}
