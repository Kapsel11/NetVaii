using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Fajn.Models
{
    public class Game
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
        public string Event { get; set; }
        //[Required]
        public string Pgn { get; set; }

        public IdentityUser user { get; set; }
        public Game()
        {

        }
    }
}
