namespace UsedCars.Entities;

public class Car
{
    public int Id { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public int Year { get; set; }

    public decimal Price { get; set; }

    public bool Licensed { get; set; }

    public DateTime DateAdded { get; set; }

    public int WarehouseId { get; set; }

    public Warehouse Warehouse { get; set; }
}