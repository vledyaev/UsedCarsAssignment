using UsedCars.Entities;

namespace UsedCars.UnitOfWork;

public interface IUnitOfWork
{
    IGenericRepository<Car> Cars { get; }

    IGenericRepository<Warehouse> Warehouses { get; }

    int Complete();
}