using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.services.Interfaces
{
    public interface IFiefForeinKeyRepository<T>
    {
        Task<T?> GetByFiefIdAsync(Guid fiefId);
        Task<ICollection<T>> GetListByFiefIdAsync(Guid fiefId);
    }
}
