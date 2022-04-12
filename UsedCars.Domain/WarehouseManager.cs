using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UsedCars.Domain.Models;
using UsedCars.UnitOfWork;

namespace UsedCars.Domain;

public class WarehouseManager: IWarehouseManager
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public WarehouseManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<WarehouseModel> GetWarehouse(int warehouseId)
    {
        return await _mapper.ProjectTo<WarehouseModel>(_unitOfWork.Warehouses.GetAll().Where(x => x.Id == warehouseId)).FirstOrDefaultAsync();
    }
}