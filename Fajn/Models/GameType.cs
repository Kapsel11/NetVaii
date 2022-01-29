using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Fajn.Models
{
    public class GameType
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        public string Rules { get; set; } = string.Empty;
        public ICollection<Game> Games { get; set; }
    }
}
