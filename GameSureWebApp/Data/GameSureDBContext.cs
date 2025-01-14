﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameSureWebApp.Areas.Identity.Data;
using GameSureWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameSureWebApp.Data
{
    public class GameSureDBContext : IdentityDbContext<GameSureWebAppUser>
    {
        public GameSureDBContext(DbContextOptions<GameSureDBContext> options)
            : base(options)
        {
        }
        public DbSet<GameSureWebAppUser> GameSureWebAppUsers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<TransactionDet> TransactionDets { get; set; }
        public DbSet<PaymentMethod> Payments { get; set; }
        public DbSet<Address> Addresses { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
