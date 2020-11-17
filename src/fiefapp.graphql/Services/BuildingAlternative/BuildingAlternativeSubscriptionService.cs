using fiefapp.mongodb.Repositories.BuildingAlternative;
using System;
using System.Collections.Concurrent;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace fiefapp.graphql.Services.BuildingAlternative
{
    public class BuildingAlternativeSubscriptionService : IBuildingAlternativeSubscriptionService
    {
        private readonly ISubject<entities.BuildingAlternative> _buildingAlternativeStream = new ReplaySubject<entities.BuildingAlternative>(1);
        private readonly IBuildingAlternativeRepository _repository;

        public BuildingAlternativeSubscriptionService(IBuildingAlternativeRepository repository)
        {
            _repository = repository;

            AllBuildingAlternatives = new ConcurrentStack<entities.BuildingAlternative>();
        }

        public ConcurrentStack<entities.BuildingAlternative> AllBuildingAlternatives { get; }

        public entities.BuildingAlternative AddBuildingAlternative(entities.BuildingAlternative alternative)
        {
            var addedAlternative = _repository.AddBuildingAlternative(alternative);
            AllBuildingAlternatives.Push(addedAlternative);
            _buildingAlternativeStream.OnNext(addedAlternative);

            return addedAlternative;
        }

        public IObservable<entities.BuildingAlternative> BuildingAlternatives()
        {
            return _buildingAlternativeStream.AsObservable();
        }
    }
}
