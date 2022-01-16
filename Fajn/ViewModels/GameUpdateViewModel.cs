using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Fajn.Models;

namespace Fajn.ViewModels
{
    public class GameUpdateViewModel
    {
        [Required]
        public string White { get; set; }
        [Required]
        public string Black { get; set; }
        [Required]
        public string Result { get; set; }
        public string Date { get; set; }
        public string Pgn { get; set; }
        public int EventId { get; set; }
        public int id  { get; set; }
        public IEnumerable<Event> Events { get; set; }
    }
}
