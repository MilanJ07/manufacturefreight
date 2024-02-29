using DataAccess.Domain;

namespace DataAccess.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : EntityBase
    {
        Task<TEntity?> FindAsync(Guid id);
        Task<TEntity?> AddAsync(TEntity entity);
    }
}
