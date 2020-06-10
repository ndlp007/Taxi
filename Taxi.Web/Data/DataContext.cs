﻿using Microsoft.EntityFrameworkCore;
using Taxi.Web.Data.Entities;

namespace Taxi.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<TaxiEntity> Taxis { get; set; }
        public DbSet<TripEntity> Trips { get; set; }
        public DbSet<TripDetailEntity> TripDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<TaxiEntity>()
                .HasIndex(t => t.Plaque)
                .IsUnique();
        }


    }
}
