using Microsoft.AspNetCore.Mvc;
using System;
using EncounterMeAPI.Services;
using EncounterMeAPI.Entities;
using System.Threading.Tasks;

namespace EncounterMeAPI.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly TrailService _trailService;
        private readonly StatisticsService _statisticsService;

        public StatisticsController(StatisticsService statisticsService, TrailService trailService)
        {
            _trailService = trailService;
            _statisticsService = statisticsService;
        }
        [HttpGet]
        public async Task<ActionResult<WalkStatistics>> GetWalkStatisticsAsync(Guid trailId, int time, double weight)
        {
            var trail = await _trailService.GetTrailByIdAsync(trailId);
            // Throw exceptions in service and use a filter to catch them globally ???
            if (trail == null)
            {
                return NotFound();
            }

            var stats = _statisticsService.CalculateStatistics(trail, time, weight);

            return stats;
        }
    }
}
