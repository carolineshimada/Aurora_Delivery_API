﻿using Microsoft.EntityFrameworkCore;
using AuroraDelivery.Domain.Entities;

namespace AuroraDelivery.Infra.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}