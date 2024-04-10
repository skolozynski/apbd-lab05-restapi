using Lab_05_WebApi.Database;
using Lab_05_WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_05_WebApi.Controllers;

[ApiController]
[Route("/visits")]
public class VisitsController : ControllerBase
{
    
    [HttpGet("{AnimalId}")]
    public IActionResult GetVisitByAnimalID(int AnimalId)
    {
        var visit = new MockDb().Visits.FirstOrDefault(x => x.AnimalId == AnimalId);
        if (visit == null)
        {
            return NotFound();
        }
        return Ok(visit);
    }
    
    [HttpPost]
    public IActionResult AddVisit(Visit visit)
    {
        var visits = new MockDb().Visits;
        visits.Add(visit);
        
        return Created("", visit);
    }
    
}