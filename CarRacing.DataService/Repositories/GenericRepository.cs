using CarRacing.DataService.Data;
using CarRacing.DataService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CarRacing.DataService.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T: class
{
    public readonly ILogger _logger;
    protected AppDbContext _context;
    internal DbSet<T> _dbSet;

    public GenericRepository(ILogger logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
        _dbSet = context.Set<T>();
    }


    public async Task<IEnumerable<T>> All()
    {
        throw new NotImplementedException();
    }

    public async Task<T?> GetById(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<bool> Add(T entity)
    {
         await _dbSet.AddAsync(entity);
         return true;
    }

    public async Task<bool> Update(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}