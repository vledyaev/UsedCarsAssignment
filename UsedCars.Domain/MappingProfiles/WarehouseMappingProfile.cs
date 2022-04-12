using AutoMapper;
using UsedCars.Domain.Models;
using UsedCars.Entities;

namespace UsedCars.Domain.MappingProfiles;

public class WarehouseMappingProfile: Profile
{
    public WarehouseMappingProfile()
    {
        CreateMap<Warehouse, WarehouseModel>();
    }
}