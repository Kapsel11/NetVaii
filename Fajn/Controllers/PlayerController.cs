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
    public class PlayerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IWebHostEnvironment hostingEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<Microsoft.AspNetCore.Identity.IdentityUser> _userManager;
        public PlayerController(ApplicationDbContext context, IWebHostEnvironment environment, UserManager<Microsoft.AspNetCore.Identity.IdentityUser> userManager)
        {
            hostingEnvironment = environment;
            _context = context;
            _userManager = userManager;
        }

       
        public async Task<IActionResult> Index()
        {
            return View(await _context.Player.ToListAsync());
        }

        [Authorize]
        public async Task<IActionResult> AddPlayer()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Add(Player player)
        {
            if (ModelState.IsValid)
            {
                _context.Add(player);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public async Task<IActionResult> Update(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var f = await _context.Player.FindAsync(id);
            if (f == null)
            {
                return NotFound();
            }
            return View(f);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Player player,int? id)
        {
            if (id != player.Id)
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                try
                {
                    _context.Update(player);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerExists(player.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Delete(int Id)
        {
            var gate = await _context.Player.FindAsync(Id);
            if (gate != null)
            {
                _context.Player.Remove(gate);
                await _context.SaveChangesAsync();
            }
            List<Player> f = await _context.Player.ToListAsync();
            return PartialView("Index", f);
        }

        private bool PlayerExists(int id)
        {
            return _context.Player.Any(e => e.Id == id);
        }
    }
}

