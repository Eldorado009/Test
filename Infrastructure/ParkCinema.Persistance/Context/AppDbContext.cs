﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParkCinema.Domain.Entities;
using ParkCinema.Persistance.Configurations;

namespace ParkCinema.Persistance.Context;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SliderConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Test> Tests { get; set; }
}
