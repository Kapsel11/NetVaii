using Microsoft.AspNetCore.Mvc;
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
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly UserManager<Microsoft.AspNetCore.Identity.IdentityUser> _userManager;
        public EventController(ApplicationDbContext context, IWebHostEnvironment environment, UserManager<Microsoft.AspNetCore.Identity.IdentityUser> userManager)
        {
            hostingEnvironment = environment;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Event.ToListAsync());
        }

        [Authorize]
        public async Task<IActionResult> AddEvent()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(string EventName, string StartingDate, string EndingDate)
        {
            if (ModelState.IsValid)
            {
                Event pom = new Event();
                pom.EventName = EventName;
                pom.StartingDate = DateTime.Parse(StartingDate);
                pom.EndingDate = DateTime.Parse(EndingDate);
                _context.Add(pom);
                await _context.SaveChangesAsync();
            }
            return PartialView(nameof(Index));
        }

    }
}
