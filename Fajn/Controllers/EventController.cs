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
        public async Task<IActionResult> Add(Event f)
        {
            if (ModelState.IsValid)
            {
                _context.Add(f);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
