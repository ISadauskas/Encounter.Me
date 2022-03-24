using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EncounterMeAPI.Entities;
using EncounterMeAPI.Persistance;
using EncounterMeAPI.Utilities.Exceptions;
using FluentValidation;

namespace EncounterMeAPI.Services
{
    public class TrailService : ITrailService
    {

        private readonly ApplicationDbContext _dbContext;

        public TrailService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        TrailValidator validator = new TrailValidator();

        public async Task AddNewTrailAsync(Trail trail)
        {
            validator.ValidateAndThrow(trail);
            // If object is faulty will throw a Validation exception with faulty field errors

            await _dbContext.Trails.AddAsync(trail);
        }

        public async Task EditTrailAsnyc(Trail trail)
        {
            var currentTrail = await _dbContext.Trails.FindAsync(trail.Id);

            if (currentTrail is null)
            {
                throw new NotFoundException($"Trail with Id: {trail.Id} could not be found");
            }

            var mapperConfig = new MapperConfiguration(cfg =>
                cfg.CreateMap<Trail, Trail>().ForAllMembers(
                    x => x.Condition((source, destination, member) => member != null)));
            // configure mapper to not ignore null values
            //TODO validate the values that are being mapped, validator object cant be used, doesnt allow null's

            var mapper = new Mapper(mapperConfig);

            mapper.Map(trail, currentTrail);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Trail>> GetPaginatedTrailsAsync(int pageNumber, int itemsPerPage)
        {
            return _dbContext.Trails
                .OrderByDescending(x => x.UploadDate)
                .Skip((pageNumber - 1) * itemsPerPage)
                .Take(itemsPerPage);
        }

        public async Task<Trail> GetTrailByIdAsync(Guid id)
        {
            var trail = await _dbContext.Trails.FindAsync(id);

            if (trail is null)
            {
                throw new NotFoundException($"Trail with id: {id} could not be found");
            }

            return trail;
        }

        public async Task RemoveTrailAsnyc(Guid id)
        {
            var trail = await _dbContext.Trails.FindAsync(id);

            if (trail is null)
            {
                throw new NotFoundException($"Trail with id: {id} does not exist");
            }

            _dbContext.Remove(trail);
            await _dbContext.SaveChangesAsync();
        }
    }
}
