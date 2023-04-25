using FilmStore.Data.Base.eTickets.Data.Base;
using System.Linq.Expressions;

namespace FilmStore.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(int id);
        Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includeProperties);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
