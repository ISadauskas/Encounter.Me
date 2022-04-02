using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EncounterMeAPI.Entities;

public interface ITrailService
{
    public Task<Trail> GetTrailByIdAsync(Guid id);
    public Task<IEnumerable<Trail>> GetPaginatedTrailsAsync(int pageNumber, int pageSize);
    public Task AddNewTrailAsync(Trail trail);
    public Task RemoveTrailAsync(Guid id);
    public Task EditTrailAsync(Trail trail);
}
