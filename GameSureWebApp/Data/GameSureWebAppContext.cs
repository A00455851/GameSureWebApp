using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameSureWebApp.Models;

namespace GameSureWebApp.Data
{
    public class GameSureWebAppContext : DbContext
    {
        public GameSureWebAppContext (DbContextOptions<GameSureWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<GameSureWebApp.Models.Product> Product { get; set; }
    }
}
