using Microsoft.EntityFrameworkCore;
using Tutorial.Entitys;

namespace Tutorial;

public class DataContext : DbContext
{
    public DbSet<SuperHero>SuperHeroes { get; set; }
    public DbSet<SuperPower>SuperPowers { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=SUPERHEROS;Trusted_Connection=True;TrustServerCertificate=True;");
    }
    
    
}