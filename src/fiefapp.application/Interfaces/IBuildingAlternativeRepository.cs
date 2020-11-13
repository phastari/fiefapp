using fiefapp.mongodb.DTOs;
using System.Collections.Generic;

namespace fiefapp.api.Interfaces
{
    public interface IBuildingAlternativeRepository
    {
        List<BuildingAlternativeDTO> Get();
        BuildingAlternativeDTO Get(string id);
        BuildingAlternativeDTO Create(BuildingAlternativeDTO alternative);
        void Update(string id, BuildingAlternativeDTO alternativeIn);
        void Remove(BuildingAlternativeDTO alternativeIn);
        void Remove(string id);
    }
}
