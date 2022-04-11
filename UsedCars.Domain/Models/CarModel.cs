namespace UsedCars.Domain.Models;

public class CarModel
{
    public string Id { get; set; }

    public string Make { get; set; }

    public string Model { get; set; }

    public decimal Price { get; set; }

    public bool Licensed { get; set; }

    public DateTime DateAdded { get; set; }

    public int Year { get; set; }

    public string Warehouse { get; set; }
}