using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncounterMeAPI.Entities;
using EncounterMeAPI.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EncounterMeAPI.Controllers;

[TypeFilter(typeof(ApiExceptionFilter))]
[Route("[controller]")]
[ApiController]
public class TrailController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly ITrailService _trailService;

    public TrailController (ITrailService trailService, IConfiguration configuration)
    {
        _trailService = trailService;
        _configuration = configuration;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Trail>>> GetPaginatedTrails (int pageNumber = 1, int itemsPerPage = 15)
    {
        var paginatedTrails = await _trailService.GetPaginatedTrailsAsync(pageNumber, itemsPerPage);
        return Ok(paginatedTrails);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Trail>> GetTrailById (Guid id)
    {
        var trail = await _trailService.GetTrailByIdAsync(id);
        return Ok(trail);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTrail (Trail trail)
    {
        await _trailService.AddNewTrailAsync(trail);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateTrail (Trail trail)
    {
        await _trailService.EditTrailAsync(trail);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveTrail (Guid id)
    {
        var configAccessCode = _configuration.GetValue<string>("AdminAccessCode");
        var requestAccessCode = Request.Headers["AdminAccessCode"].FirstOrDefault();

        if (configAccessCode != null &&
            (requestAccessCode == null || configAccessCode != requestAccessCode))
        {
            return StatusCode(403);
        }

        await _trailService.RemoveTrailAsync(id);

        return Ok();
    }
}
