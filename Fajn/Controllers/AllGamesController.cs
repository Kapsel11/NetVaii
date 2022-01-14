using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Fajn.Data;
using Fajn.ViewModels;

namespace Fajn.Controllers
{
    public class AllGamesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AllGamesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public  IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Find(string SearchString, int Option)
        {
            var games = from g in _context.AllGames
                        join t in _context.Event
                        on g.EventId equals t.EventId

                        select new
                        {
                            g.GameId,
                            g.White,
                            g.Black,
                            g.Result,
                            t.EventName,
                            g.Date,
                            g.Pgn
                        };

            if (SearchString == null || SearchString.Length == 0)
            {

            }
            else
            {
                switch (Option)
                {
                    case 0:
                        games = games.Where(s => s.White.Contains(SearchString) || s.Black.Contains(SearchString));
                        break;
                    case 1:
                        games = games.Where(s => s.Result.Contains(SearchString));
                        break;
                    case 2:
                        games = games.Where(s => s.EventName.Contains(SearchString));
                        break;
                }
            }

            List<AllGamesFindViewModel> newList = new List<AllGamesFindViewModel>();
            foreach (var item in games)
            {
                AllGamesFindViewModel listItem = new AllGamesFindViewModel();
                listItem.GameId = item.GameId;
                listItem.White = item.White;
                listItem.Black = item.Black;
                listItem.Result = item.Result;
                listItem.EventName = item.EventName;
                listItem.Date = item.Date;
                listItem.Pgn = item.Pgn;

                newList.Add(listItem);
            }

            return View(newList);
        }

    }
}
