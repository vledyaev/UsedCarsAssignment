using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UsedCars.Domain.Models;
using UsedCars.UnitOfWork;

namespace UsedCars.Domain;

public class CarManager: ICarManager
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CarManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CarModel>> GetCars()
    {
        return await _mapper.ProjectTo<CarModel>(_unitOfWork.Cars.GetAll()).ToListAsync();
    }
}