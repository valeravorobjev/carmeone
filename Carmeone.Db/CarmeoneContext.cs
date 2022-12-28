using Carmeone.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db;

public class CarmeoneContext: DbContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<CompanyUser> CompanyUsers { get; set; }
    public DbSet<IndividualUser> IndividualUsers { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Moto> Motos { get; set; }
    public DbSet<Bus> Buses { get; set; }
}