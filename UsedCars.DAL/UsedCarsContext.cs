using Microsoft.EntityFrameworkCore;
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
}