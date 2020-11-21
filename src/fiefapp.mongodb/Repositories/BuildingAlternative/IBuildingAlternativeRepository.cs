﻿using System.Collections.Generic;

namespace fiefapp.mongodb.Repositories.BuildingAlternative
{
    public interface IBuildingAlternativeRepository
    {
        List<entities.BuildingAlternative> Get();
        List<entities.BuildingAlternative> Get(string id);
        entities.BuildingAlternative Create(entities.BuildingAlternative alternative);
        void Update(string id, entities.BuildingAlternative alternativeIn);
        void Remove(entities.BuildingAlternative alternativeIn);
        void Remove(string id);

        entities.BuildingAlternative AddBuildingAlternative(entities.BuildingAlternative alternative);
    }
}
