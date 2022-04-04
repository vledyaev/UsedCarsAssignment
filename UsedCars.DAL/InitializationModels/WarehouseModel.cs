namespace UsedCars.DAL.InitializationModels;

public class WarehouseModel
{
    public int _Id { get; set; }

    public string Name { get; set; }

    public LocationModel Location { get; set; }

    public CarsModel Cars { get; set; }
}