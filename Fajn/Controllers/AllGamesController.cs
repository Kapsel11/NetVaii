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
            var games = from g in _context.AllGames select g;

            if(SearchString == null || SearchString.Length == 0)
            {
                return View(await games.ToListAsync());
            }
            switch (Option)
            {
                case 0:
                    games = games.Where(s => s.White.Contains(SearchString) || s.Black.Contains(SearchString));
                    break;
                case 1:
                    games = games.Where(s => s.Result.Contains(SearchString));
                    break;
                case 2:
                    games = games.Where(s => s.Event.Contains(SearchString));
                    break;
            }
            return View(await games.ToListAsync());
        }

    }
}
