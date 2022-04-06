using UsedCars.DAL;

namespace UsedCars.UnitOfWork;

public class GenericRepository<T>: IGenericRepository<T> where T: class
{
    private readonly UsedCarsContext _context;

    public GenericRepository(UsedCarsContext context)
    {
        _context = context;
    }

    public IQueryable<T> GetAll()
    {
        return _context.Set<T>().AsQueryable();
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
}