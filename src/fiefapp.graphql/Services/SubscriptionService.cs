using fiefapp.entities;
using fiefapp.graphql.Enums;
using fiefapp.graphql.Models;
using fiefapp.services.Interfaces;
using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;

namespace fiefapp.graphql.Services
{
    class SubscriptionService<T> : ISubscriptionService<T> where T : class, IBaseEntity
    {
        private readonly ISubject<MutationResponse<T>> _stream = new ReplaySubject<MutationResponse<T>>(1);
        private readonly IRepository<T> _repository;

        public SubscriptionService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<MutationResponse<T>> Add(T entity)
        {
            var added = await _repository.InsertAsync(entity);

            var response = new MutationResponse<T>
            {
                Type = MutationAction.ADD,
                ActionSucceeded = added != null,
                Entity = added ?? default,
            };

            _stream.OnNext(response);
            return response;
        }

        public async Task<MutationResponse<T>> Update(T entity)
        {
            var updated = await _repository.UpdateAsync(entity);
            var response = new MutationResponse<T>
            {
                Type = MutationAction.UPDATE,
                ActionSucceeded = updated != null,
                Entity = updated ?? default,
            };

            _stream.OnNext(response);
            return response;
        }

        public async Task<MutationResponse<T>> Delete(Guid id)
        {
            var deleted = await _repository.DeleteAsync(id);
            var response = new MutationResponse<T>
            {
                Type = MutationAction.DELETE,
                ActionSucceeded = deleted != null,
                DeletedId = deleted == null ? default : deleted.Id,
            };

            _stream.OnNext(response);
            return response;
        }

        public IObservable<MutationResponse<T>> Entities()
        {
            return _stream.AsObservable();
        }
    }
}
