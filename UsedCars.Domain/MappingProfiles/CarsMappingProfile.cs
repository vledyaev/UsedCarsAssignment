using AutoMapper;
using UsedCars.Domain.Models;
using UsedCars.Entities;

namespace UsedCars.Domain.MappingProfiles;

public class CarsMappingProfile: Profile
{
    public CarsMappingProfile()
    {
        CreateMap<Car, CarModel>();
    }
}