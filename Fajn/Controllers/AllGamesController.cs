using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fajn.Data;
using Fajn.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.Extensions.Hosting.Internal;
using Fajn.Other;
using Fajn.ViewModels;


namespace Fajn.Controllers
{
    public class AllGamesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IWebHostEnvironment hostingEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<Microsoft.AspNetCore.Identity.IdentityUser> _userManager;
        public AllGamesController(ApplicationDbContext context, IWebHostEnvironment environment, UserManager<Microsoft.AspNetCore.Identity.IdentityUser> userManager)
        {
            hostingEnvironment = environment;
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public  IActionResult Search()
        {
            return View();
        }


        [Authorize]
        public async Task<IActionResult> AddGame()
        {
            GameCreateGameViewModel model = new GameCreateGameViewModel();
            model.Events = await _context.Event.ToListAsync();
            return View(model);
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(string White, string Black, string Result, string Date, int EventId, string Pgn)
        {
            AllGames nova = new AllGames();

            nova.Pgn = Pgn.Replace("\\", "");
            nova.Pgn.Replace(" ", "");
            nova.Date = Date;
            nova.White = White;
            nova.Black = Black;
            nova.EventId = EventId;
            nova.Result = Result;

            if (ModelState.IsValid)
            {
                _context.Add(nova);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Search));
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
