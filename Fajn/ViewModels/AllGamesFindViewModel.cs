using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fajn.ViewModels
{
    public class AllGamesFindViewModel
    {
            public int GameId { get; set; }
            public string White { get; set; }
            public string Black { get; set; }
            public string Result { get; set; }
            public string EventName { get; set; }
            public string Date { get; set; }
            public string Pgn { get; set; }

    }

}
