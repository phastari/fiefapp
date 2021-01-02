using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.services.Interfaces
{
    public interface IAssignableRepository<T>
    {
        Task<T?> GetOneByEntityIdAsync(Guid id);
        Task<ICollection<T>> GetListByEntityIdAsync(Guid id);
    }
}
