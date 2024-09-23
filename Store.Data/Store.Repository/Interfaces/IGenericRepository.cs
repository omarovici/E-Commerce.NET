using Store.Data.Entities;

namespace Store.Repository.Interfaces;

public interface IGenericRepository<TEntity,TKey> where TEntity : BaseEntity<TKey>
{
    Task<TEntity> GetByIdAsync(TKey? id);
    Task <IReadOnlyList<TEntity>> GetAllAsync();
    Task <IReadOnlyList<TEntity>> GetAllAsNoTrackingAsync();
    Task AddAsync(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}