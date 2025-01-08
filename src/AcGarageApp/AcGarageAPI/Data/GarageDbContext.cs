using AcGarageAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcGarageAPI.Data;

public class GarageDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Car> Cars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().Property(e => e.Make)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);

        modelBuilder.Entity<Car>().Property(e => e.Model)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);

        modelBuilder.Entity<Car>().Property(e => e.Registration)
            .IsRequired()
            .HasMaxLength(10)
            .IsUnicode(false);

        modelBuilder.Entity<Car>()
            .ToTable(nameof(Car));

        base.OnModelCreating(modelBuilder);
    }
}