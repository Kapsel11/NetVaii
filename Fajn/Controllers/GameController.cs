using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    public class GameController : Controller
    {
        private static int fajl = 0;
        private readonly ApplicationDbContext _context;
        private IWebHostEnvironment hostingEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<Microsoft.AspNetCore.Identity.IdentityUser> _userManager;

        public GameController(ApplicationDbContext context, IWebHostEnvironment environment, UserManager<Microsoft.AspNetCore.Identity.IdentityUser> userManager)
        {
            hostingEnvironment = environment;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Games.ToListAsync());
        }

        [Authorize]
        public async Task<IActionResult> CreateGame()
        {
            GameCreateGameViewModel model = new GameCreateGameViewModel();
            model.Events = await _context.Event.ToListAsync();
            return View(model);

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joke = await _context.Games
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (joke == null)
            {
                return NotFound();
            }

            return View(joke);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(GameCreateGameViewModel game, IFormFile pgn)
        {
            Game nova = new Game();
            var user = await _userManager.GetUserAsync(HttpContext.User);
            string path = "Pgn/" + user.UserName + "/" + pgn.FileName;

            string dir = "Pgn/" + user.UserName;

            if (pgn == null)
                ModelState.AddModelError(nameof(game.Pgn), "Please select pgn file");
            else
            {
                nova.Pgn = "~/" + path;
                nova.user = user;
                nova.Date = game.Date;
                nova.White = game.White;
                nova.Black = game.Black;
                nova.EventId = game.EventId;
                nova.Result = game.Result;
                Directory.CreateDirectory(Path.Combine(hostingEnvironment.WebRootPath, dir));
            }

                using (var stream = new System.IO.FileStream(Path.Combine(hostingEnvironment.WebRootPath, path), FileMode.Create))
                {
                    await pgn.CopyToAsync(stream);
                }
                _context.Add(nova);
                await _context.SaveChangesAsync();
               return RedirectToAction(nameof(MyGames));

            return RedirectToAction(nameof(MyGames));
        }


        [Authorize]
        public async Task<IActionResult> MyGames()
        {
            var games = from g in _context.Games select g;
            var user = await _userManager.GetUserAsync(HttpContext.User);
            games = games.Where(s => s.user.Equals(user));

             var events = await _context.Event.ToListAsync();


            List<AllGamesFindViewModel> newList = new List<AllGamesFindViewModel>();
            foreach (var item in games)
            {
                string EventName = new string("");
                if(item.EventId != null)
                {
                     EventName = events.Where(s => s.EventId.Equals(item.EventId)).FirstOrDefault().EventName;
                }
                AllGamesFindViewModel listItem = new AllGamesFindViewModel();
                listItem.GameId = item.GameId;
                listItem.White = item.White;
                listItem.Black = item.Black;
                listItem.Result = item.Result;
                listItem.EventName = EventName;
                listItem.Date = item.Date;
                listItem.Pgn = item.Pgn;

                newList.Add(listItem);
            }

            return View(newList);

        }

        public async Task<IActionResult> Update(int? id)
        {
            Game f = _context.Games.Find(id);
            return View(f);
        }

        public async Task<IActionResult> Delete(int? id) 
        {
            Game pom = _context.Games.Find(id);
            _context.Entry(pom).State = EntityState.Deleted;
            _context.Remove(pom);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MyGames));
        }

       [Authorize]
       [HttpPost]
        public async Task<IActionResult> Update(Game game, IFormFile pgn, int id)
        {
            Game pom = _context.Games.Find(id);
            _context.Entry(pom).State = EntityState.Deleted;
            game.GameId = pom.GameId;
            game.Pgn = pom.Pgn;
            _context.Remove(pom);

            var user = await _userManager.GetUserAsync(HttpContext.User);
            _context.Update(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MyGames));

        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,About")] Game game)
        {
            if (id != game.GameId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.GameId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

      
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Games.FindAsync(id);
            _context.Games.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
            return _context.Games.Any(e => e.GameId == id);
        }
    }
}