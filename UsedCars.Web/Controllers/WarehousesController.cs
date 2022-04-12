using Microsoft.AspNetCore.Mvc;
using UsedCars.Domain;
using UsedCars.Domain.Models;

namespace UsedCars.Controllers;

[ApiController]
[Route("[controller]")]
public class WarehousesController: ControllerBase
{
    private readonly IWarehouseManager _warehouseManager;

    public WarehousesController(IWarehouseManager warehouseManager)
    {
        _warehouseManager = warehouseManager;
    }

    [HttpGet]
    public async Task<WarehouseModel> Get(int id)
    {
        return await _warehouseManager.GetWarehouse(id);
    }
}