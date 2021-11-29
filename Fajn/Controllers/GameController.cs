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

        // GET: Jokes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Games.ToListAsync());
        }

        // GET: Jokes
        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> CreateGame()
        {
            return View();
        }

        // GET: Jokes/Details/5
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

        // POST: Jokes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(Game game, IFormFile pgn)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            string path = "Pgn/" + user.UserName + "/" + pgn.FileName;

            string dir = "Pgn/" + user.UserName;

            if (pgn == null)
                ModelState.AddModelError(nameof(game.Pgn), "Please select pgn file");
            else
            {
                game.Pgn = "~/" + path;
                game.user = user; 
                Directory.CreateDirectory(Path.Combine(hostingEnvironment.WebRootPath, dir));
            }

            //if (ModelState.IsValid)
            {
                using (var stream = new System.IO.FileStream(Path.Combine(hostingEnvironment.WebRootPath, path), FileMode.Create))
                {
                    await pgn.CopyToAsync(stream);
                }
                _context.Add(game);
                await _context.SaveChangesAsync();
                // return RedirectToAction(nameof(Index));
                return View(nameof(ShowSearchForm));
            }

            return View(nameof(ShowSearchForm));
        }

        [Authorize]
        public async Task<IActionResult> MyGames()
        {
           // List<Game> game = (from customer in this._context.Games.Take(10)
            //                            select customer).ToList();

            var games = from g in _context.Games select g;
            var user = await _userManager.GetUserAsync(HttpContext.User);
            games = games.Where(s => s.user.Equals(user));

            return View(await games.ToListAsync());
        }



        // GET: Jokes/Edit/5 [HttpPost]
        public async Task<IActionResult> Update(int? id)
        {
            Game f = _context.Games.Find(id);
            return View(f);
        }

        public async Task<IActionResult> Delete(int? id) // PRIDAT OSETRENIE
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
            _context.Remove(pom);

            var user = await _userManager.GetUserAsync(HttpContext.User);
            string path = "Pgn/" + user.UserName + "/" + pgn.FileName;

            string dir = "Pgn/" + user.UserName;

            if (pgn == null)
                ModelState.AddModelError(nameof(game.Pgn), "Please select pgn file");
            else
            {
                game.Pgn = "~/" + path;
                game.user = user;
                Directory.CreateDirectory(Path.Combine(hostingEnvironment.WebRootPath, dir));
            }

            //if (ModelState.IsValid)
            {
                using (var stream = new System.IO.FileStream(Path.Combine(hostingEnvironment.WebRootPath, path), FileMode.Create))
                {
                    await pgn.CopyToAsync(stream);
                }
                _context.Update(game);
                await _context.SaveChangesAsync();
                // return RedirectToAction(nameof(Index));
                return RedirectToAction(nameof(MyGames));
            }

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

        // POST: Jokes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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
                    if (!JokeExists(game.GameId))
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

        // POST: Jokes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Games.FindAsync(id);
            _context.Games.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JokeExists(int id)
        {
            return _context.Games.Any(e => e.GameId == id);
        }
    }
}