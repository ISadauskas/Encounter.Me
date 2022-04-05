using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EncounterMeAPI.Entities;
using EncounterMeAPI.Persistance;
using FluentValidation;

namespace EncounterMeAPI.Services
{
    public class TrailService : ITrailService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly TrailValidator _trailValidator;
        private readonly Mapper _mapper;

        public TrailService(ApplicationDbContext dbContext, TrailValidator trailValidator)
        {
            _dbContext = dbContext;
            _trailValidator = trailValidator;

            var mapperConfig = new MapperConfiguration(cfg =>
                cfg.CreateMap<Trail, Trail>().ForAllMembers(
                    x => x.Condition((source, destination, member) => member != null)));
            _mapper = new Mapper(mapperConfig);
        }

        public async Task AddNewTrailAsync(Trail trail)
        {
            _trailValidator.ValidateAndThrow(trail);
            // If object is faulty will throw a Validation exception with faulty field errors

            await _dbContext.Trails.AddAsync(trail);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditTrailAsync(Trail trail)
        {
            var currentTrail = await _dbContext.Trails.FindAsync(trail.Id);

            if (currentTrail is null)
            {
                throw new ArgumentException($"Trail with Id: {trail.Id} could not be found");
            }

            _mapper.Map(trail, currentTrail);

            _trailValidator.ValidateAndThrow(trail);

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
                throw new ArgumentException($"Trail with id: {id} could not be found");
            }

            return trail;
        }

        public async Task RemoveTrailAsync(Guid id)
        {
            var trail = await _dbContext.Trails.FindAsync(id);

            if (trail is null)
            {
                throw new ArgumentException($"Trail with id: {id} does not exist");
            }

            _dbContext.Remove(trail);
            await _dbContext.SaveChangesAsync();
        }
    }
}
