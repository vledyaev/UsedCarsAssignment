using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;
using UsedCars.DAL.InitializationModels;
using UsedCars.Entities;

namespace UsedCars.DAL;

public class UsedCarsContext: DbContext
{
    public DbSet<Car> Cars { get; set; }

    public DbSet<Warehouse> Warehouses { get; set; }

    private string _dbPath;

    public UsedCarsContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        _dbPath = Path.Join(path, "used_cars.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={_dbPath}");

    protected override void OnModelCreating(ModelBuilder builder)
    {
        using var reader = new StreamReader("warehouses.json");

        var json = reader.ReadToEnd();
        var warehouses = JsonConvert.DeserializeObject<List<WarehouseModel>>(json);

        if (warehouses != null)
        {
            builder.Entity<Warehouse>()
                .HasData(warehouses.Select(x => new Warehouse
                {
                    Id = x._Id,
                    Latitude = x.Location.Lat,
                    Longitude = x.Location.Long,
                    Name = x.Name,
                    Location = x.Cars.Location
                }));

            builder.Entity<Car>()
                .HasData(warehouses.SelectMany(warehouse => warehouse.Cars.Vehicles.Select(car => new Car
                {
                    Id = car._Id,
                    WarehouseId = warehouse._Id,
                    Licensed = car.Licensed,
                    Make = car.Make,
                    Model = car.Model,
                    Price = car.Price,
                    Year = car.Year_Model,
                    DateAdded = car.Date_Added
                })));
        }

        base.OnModelCreating(builder);
    }
}