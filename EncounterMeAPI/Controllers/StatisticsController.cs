using Microsoft.AspNetCore.Mvc;
using System;
using EncounterMeAPI.Services;
using EncounterMeAPI.Entities;
using EncounterMeAPI.Filters;
using System.Threading.Tasks;

namespace EncounterMeAPI.Controllers
{
    [TypeFilter(typeof(ApiExceptionFilter))]
    [Route("[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly ITrailService _trailService;
        private IStatisticsService _statisticsService;

        public StatisticsController (IStatisticsService statisticsService, ITrailService trailService)
        {
            _trailService = trailService;
            _statisticsService = statisticsService;
        }
        [HttpGet]
        public async Task<ActionResult<WalkStatistics>> GetWalkStatisticsAsync(Guid trailId, int time, double weight)
        {
            var trail = await _trailService.GetTrailByIdAsync(trailId);

            if (trail == null)
            {
                return NotFound();
            }

            var stats = _statisticsService.CalculateStatistics(trail, time, weight);

            return stats;
        }
    }
}
