using Carmeone.Db.Entities;
using Carmeone.Db.Fluent;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db;

public class CContext : DbContext
{
    public DbSet<Account>? Accounts { get; set; }
    public DbSet<User>? Users { get; set; }
    public DbSet<CompanyUser>? CompanyUsers { get; set; }
    public DbSet<IndividualUser>? IndividualUsers { get; set; }
    public DbSet<Vehicle>? Vehicles { get; set; }
    public DbSet<Car>? Cars { get; set; }
    public DbSet<Moto>? Motos { get; set; }
    public DbSet<Bus>? Buses { get; set; }
    public DbSet<Publication>? Publications { get; set; }
    public DbSet<UserPublication>? UserPublications { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseNpgsql("Host=localhost;Database=carmeone;Username=valera;Password=P@ssw0rd")
            .UseSnakeCaseNamingConvention();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("uuid-ossp");

        modelBuilder
            .Account()
            .User()
            .CompanyUser()
            .IndividualUser()
            .Vehicle()
            .Car()
            .Bus()
            .Moto()
            .Publication()
            .UserPublication();

    }
}