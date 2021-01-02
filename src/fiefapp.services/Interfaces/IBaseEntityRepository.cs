using fiefapp.entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.services.Interfaces
{
    public interface IBaseEntityRepository<T> where T : class, IBaseEntity
    {
        Task<T?> InsertAsync(T entity);
        Task<T?> GetByIdAsync(Guid id);
        Task<T?> GetByIdAsync(Guid? id);
        Task<ICollection<T>> GetListAsync();
        Task<ICollection<T>> GetListAsync(Guid id);
        Task<ICollection<T>> GetListAsync(ICollection<Guid> ids);
        Task<T?> UpdateAsync(T entity);
        Task<T?> DeleteAsync(Guid id);
    }
}
