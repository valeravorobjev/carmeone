using Carmeone.Db.Entities;
using Carmeone.Db.Fluent;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db;

public class CarmeoneContext : DbContext
{
    public DbSet<Account>? Accounts { get; set; }
    public DbSet<User>? Users { get; set; }
    public DbSet<Company>? Companies { get; set; }
    public DbSet<Vehicle>? Vehicles { get; set; }
    public DbSet<Car>? Cars { get; set; }
    public DbSet<Moto>? Motos { get; set; }
    public DbSet<Bus>? Buses { get; set; }
    public DbSet<Publication>? Publications { get; set; }
    public DbSet<UserPublication>? UserPublications { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //TODO: Удалить строку соединения с БД
        optionsBuilder
            .UseNpgsql("Host=localhost;Database=carmeone;Username=valera;Password=password")
            .UseSnakeCaseNamingConvention();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("uuid-ossp");

        modelBuilder
            .Account()
            .User()
            .Company()
            .Vehicle()
            .Car()
            .Bus()
            .Moto()
            .Publication()
            .UserPublication();

    }
}