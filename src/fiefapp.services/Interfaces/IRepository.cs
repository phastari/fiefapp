using fiefapp.entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.services.Interfaces
{
    public interface IRepository<T> where T : class, IBaseEntity
    {
        Task<T?> InsertAsync(T entity);
        Task<T?> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetListAsync();
        Task<T?> UpdateAsync(T entity);
        Task<T?> DeleteAsync(Guid id);
    }
}
