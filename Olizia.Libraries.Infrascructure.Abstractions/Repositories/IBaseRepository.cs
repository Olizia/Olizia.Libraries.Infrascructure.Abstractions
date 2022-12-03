namespace Olizia.Libraries.Infrascructure.Abstractions.Repositories;

public interface IBaseRepository<TEntity>
    where TEntity : class
{
    Task AddAsync(TEntity entity);
    Task AddRangeAsync(List<TEntity> entities);
    Task<TEntity?> GetAsync(Guid identifier);
    Task<List<TEntity>> GetAllAsync();
    Task DeleteAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
}
