using CarRentalApp.api.Domain.IRepositories;
using CarRentalApp.api.Infrastructure.Persistence;
using System.Linq.Expressions;

namespace CarRentalApp.api.Infrastructure.Repositories;

public class GenericRepository<T>(ApplicationDbContext context) : IGenericRepository<T> where T : class
{
    private readonly ApplicationDbContext _context = context;

    public IQueryable<T> GetAll() => _context.Set<T>();

    public IQueryable<T> GetByPredicate(Expression<Func<T, bool>> predicate) =>
         _context.Set<T>().Where(predicate);

    public void Add(T entity) => _context.Set<T>().Add(entity);

    public void Update(T entity) => _context.Set<T>().Update(entity);
    public void Delete(T entity) => _context.Set<T>().Remove(entity);
}
