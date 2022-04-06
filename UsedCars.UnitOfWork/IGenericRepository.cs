namespace UsedCars.UnitOfWork;

public interface IGenericRepository<T> where T: class
{
    IQueryable<T> GetAll();
    void Add(T entity);
    void Remove(T entity);
}