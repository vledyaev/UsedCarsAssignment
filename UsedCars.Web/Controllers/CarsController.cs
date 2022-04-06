using Microsoft.AspNetCore.Mvc;
using UsedCars.Domain;
using UsedCars.Domain.Models;

namespace UsedCars.Controllers;

[ApiController]
[Route("[controller]")]
public class CarsController: ControllerBase
{
    private readonly ICarManager _carManager;

    public CarsController(ICarManager carManager)
    {
        _carManager = carManager;
    }

    [HttpGet]
    public async Task<IEnumerable<CarModel>> Get()
    {
        return await _carManager.GetCars();
    }
}