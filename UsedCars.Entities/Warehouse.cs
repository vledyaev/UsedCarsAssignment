﻿namespace UsedCars.Entities;

public class Warehouse
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Location { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public List<Car> Cars { get; } = new();
}