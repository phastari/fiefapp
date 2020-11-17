using System;
using System.Collections.Concurrent;

namespace fiefapp.graphql.Services.BuildingAlternative
{
    public interface IBuildingAlternativeSubscriptionService
    {
        ConcurrentStack<entities.BuildingAlternative> AllBuildingAlternatives { get; }
        entities.BuildingAlternative AddBuildingAlternative(entities.BuildingAlternative alternative);
        IObservable<entities.BuildingAlternative> BuildingAlternatives();
    }
}
