using UsedCars.Domain.Models;

namespace UsedCars.Domain;

public interface ICarManager
{
    Task<IEnumerable<CarModel>> GetCars();
}