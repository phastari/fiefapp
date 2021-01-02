using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.services.Interfaces
{
    public interface IAlternativesRepository<T>
    {
        Task<List<T>> GetAsync(Guid gamesessionId);
        Task<T> AddAsync(T entity);
        Task<T?> UpdateAsync(T entity);
    }
}