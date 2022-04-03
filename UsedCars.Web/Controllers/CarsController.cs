using Microsoft.AspNetCore.Mvc;

namespace UsedCars.Controllers;

[ApiController]
[Route("[controller]")]
public class CarsController: ControllerBase
{
    private readonly ILogger<CarsController> _logger;

    public CarsController(ILogger<CarsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<int> Get()
    {
        return Enumerable.Range(1, 5);
    }
}