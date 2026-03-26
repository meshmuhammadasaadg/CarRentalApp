using System.Linq.Expressions;

namespace CarRentalApp.api.Domain.IRepositories;

public interface IGenericRepository<T> where T : class
{
    IQueryable<T> GetAll();
    IQueryable<T> GetByPredicate(Expression<Func<T, bool>> predicate);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}
