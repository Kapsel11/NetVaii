using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Fajn.Models;

namespace Fajn.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Game> Games { get; set; }
        public DbSet<AllGames> AllGames { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<GameType> GameType { get; set; }
    }
}
