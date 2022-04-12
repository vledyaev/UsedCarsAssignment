using UsedCars.Domain.Models;

namespace UsedCars.Domain;

public interface IWarehouseManager
{
    Task<WarehouseModel> GetWarehouse(int warehouseId);
}