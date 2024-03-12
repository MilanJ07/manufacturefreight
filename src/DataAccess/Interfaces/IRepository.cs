using DataAccess.Domain;

namespace DataAccess.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : EntityBase
    {
        Task<TEntity?> FindAsync(decimal id);
        Task<TEntity?> AddAsync(TEntity entity);
    }
}
