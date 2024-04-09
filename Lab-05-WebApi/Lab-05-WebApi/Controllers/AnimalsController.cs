using Lab_05_WebApi.Database;
using Lab_05_WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_05_WebApi.Controllers;

[ApiController]
[Route("/animals")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;
        return Ok(animals);
    }

    [HttpGet("{id}")]
    public IActionResult GetAnimalByID(int id)
    {
        var animal = new MockDb().Animals.FirstOrDefault(x => x.Id == id);
        if (animal == null)
        {
            return NotFound();
        }
        return Ok(animal);
    }

    [HttpPost]
    public IActionResult AddAnimal()
    {
        var animals = new MockDb().Animals;
        // TODO
        
        return Created();
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id)
    {
        var animals = new MockDb().Animals;
        // TODO
        
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animals = new MockDb().Animals;
        animals.RemoveAll(x => x.Id == id);
        return NotFound();
    }
}