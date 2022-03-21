using Microsoft.AspNetCore.Mvc;
using System;
using EncounterMeAPI.Models;
using EncounterMeAPI.Services;

namespace EncounterMeAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        // private readonly TrailService _trailService;
        private readonly StatisticsService _statisticsService;

        public StatisticsController(StatisticsService statisticsService)
        {
            // _trailService = trailService;
            _statisticsService = statisticsService;
        }
        [HttpGet]
        public ActionResult<WalkStatistics> Get(string trailName, int time, double weight)
        {
            // TODO: uncomment this when trail api is done

            var trail = new Trail("Kelione i mokykla", 100, DateTime.Now, "Didlaukio 59", "Didlaukio 47");
            // var trail = _trailService.GetByName(trailName);
            // if (trail == null)
            //    return BadRequest();

            var stats = _statisticsService.CalculateStatistics(trail, time, weight);

            return stats;
        }
    }
}
