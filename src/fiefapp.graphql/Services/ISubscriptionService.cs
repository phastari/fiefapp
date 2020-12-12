using fiefapp.entities;
using fiefapp.graphql.Models;
using System;
using System.Threading.Tasks;

namespace fiefapp.graphql.Services
{
    public interface ISubscriptionService<T> where T : IBaseEntity
    {
        Task<MutationResponse<T>> Add(T entity);
        Task<MutationResponse<T>> Update(T entity);
        Task<MutationResponse<T>> Delete(Guid id);
        IObservable<MutationResponse<T>> Entities();
    }
}
