﻿using ArchitectureTemplate.Domain.DataEntities;
using ArchitectureTemplate.Infraestrutura.CrossCutting.Support.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArchitectureTemplate.Domain.Interfaces.Services
{
    public interface IProfileService : IServiceBase<Profile>
    {
        IDictionary<int, string> GetDictionary();
        Task<IDictionary<int, string>> GetDictionaryAsync();
        IEnumerable<Profile> Get(Pagination paginar);
        Task<IEnumerable<Profile>> GetAsync(Pagination paginar);
        void DisableOrEnable(long profileId, long userId);
    }
}
