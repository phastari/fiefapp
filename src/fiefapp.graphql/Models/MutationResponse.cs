using fiefapp.entities.Interfaces;
using fiefapp.graphql.Enums;
using System;

namespace fiefapp.graphql.Models
{
    public class MutationResponse<T> where T : IBaseEntity
    {
        public MutationAction Type { get; set; }
        public bool ActionSucceeded { get; set; }
        public Guid DeletedId { get; set; }
        public T Entity { get; set; }
    }
}
