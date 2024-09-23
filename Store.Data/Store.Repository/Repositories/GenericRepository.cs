using Microsoft.EntityFrameworkCore;
using Store.Data.Context;
using Store.Data.Entities;
using Store.Repository.Interfaces;

namespace Store.Repository.Repositories;

public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
{
    private readonly StoreDbContext _context;
    public GenericRepository(StoreDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TEntity entity) 
        => await _context.Set<TEntity>().AddAsync(entity);
    
    public void Delete(TEntity entity) 
        => _context.Set<TEntity>().Remove(entity);
    
    public async Task<IReadOnlyList<TEntity>> GetAllAsNoTrackingAsync()
        => await _context.Set<TEntity>().AsNoTracking().ToListAsync();

    public async Task<IReadOnlyList<TEntity>> GetAllAsync()
        => await _context.Set<TEntity>().ToListAsync();
    
    public async Task<TEntity> GetByIdAsync(TKey? id)
        => await _context.Set<TEntity>().FindAsync(id);
    
    public void Update(TEntity entity)
        => _context.Set<TEntity>().Update(entity);
}