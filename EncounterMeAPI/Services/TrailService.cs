using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EncounterMeAPI.Entities;
using EncounterMeAPI.Persistance;

namespace EncounterMeAPI.Services
{
    public class TrailService : ITrailService
    {
        private ApplicationDbContext _dbContext;

        public TrailService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddNewTrailAsync(Trail trail) => throw new NotImplementedException();
        public async Task EditTrailAsnyc(Trail trail) => throw new NotImplementedException();
        public async Task<IEnumerable<Trail>> GetPaginatedTrailsAsync(int pageNumber, int pageSize) => throw new NotImplementedException();
        public async Task<Trail> GetTrailByIdAsync(Guid id) => throw new NotImplementedException();
        public async Task RemoveTrailAsnyc(Guid id) => throw new NotImplementedException();
    }
}
