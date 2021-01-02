using fiefapp.entities.BaseClasses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.services.Interfaces
{
    public interface IIndustryRepository
    {
        Task<ICollection<Industry>> GetIndustriesForFief(Guid fiefId);
    }
}
