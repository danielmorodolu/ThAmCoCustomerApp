using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ThAmCoCustomerApp.Models;

public partial class ThAmCoDbContext : DbContext
{
    public ThAmCoDbContext()
    {
    }

    public ThAmCoDbContext(DbContextOptions<ThAmCoDbContext> options)
        : base(options)
    {
    }

    // Removed the OnConfiguring method to avoid hardcoding the connection string

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
