using DEVinCar.Domain.Models;
using DEVinCar.Infra.Datas.Mappings;
using Microsoft.EntityFrameworkCore;

namespace DEVinCar.Infra.Datas;

public class DevInCarDbContext : DbContext
{     
    public DbSet<User> Users { get; set; }

    public DbSet<City> Cities { get; set; }

    public DbSet<Car> Cars { get; set; }

    public DbSet<Sale> Sales { get; set; }

    public DbSet<SaleCar> SaleCars { get; set; }

    public DbSet<Delivery> Deliveries { get; set; }

    public DbSet<State> States { get; set; }

    public DbSet<Address> Addresses { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        base.OnConfiguring(options);
        options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=BD_DEVINCAR;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserMap());

    }
}

