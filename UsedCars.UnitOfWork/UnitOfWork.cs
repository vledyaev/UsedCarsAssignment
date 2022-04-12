using UsedCars.DAL;
using UsedCars.Entities;

namespace UsedCars.UnitOfWork;

public class UnitOfWork: IUnitOfWork
{
    private readonly UsedCarsContext _context;

    public IGenericRepository<Car> Cars { get; }

    public IGenericRepository<Warehouse> Warehouses { get; }

    public UnitOfWork(UsedCarsContext context)
    {
        _context = context;
        Cars = new GenericRepository<Car>(context);
        Warehouses = new GenericRepository<Warehouse>(context);
    }

    public int Complete()
    {
        return _context.SaveChanges();
    }
}