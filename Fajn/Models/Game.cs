using System.ComponentModel.DataAnnotations;

namespace Fajn.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public string White { get; set; }
        public string Black { get; set; }
        public string Result { get; set; }
        public string Date { get; set; }
        public string Event { get; set; }

        public Game()
        {

        }
    }
}
