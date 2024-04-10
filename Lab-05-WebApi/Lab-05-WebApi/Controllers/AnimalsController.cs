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
    public IActionResult AddAnimal(Animal animal)
    {
        var animals = new MockDb().Animals;
        var ifExist = animals.FirstOrDefault(x => x.Id == animal.Id);
        if (ifExist != null)
        {
            return Conflict("Animal with this ID already exists");
        }
        animals.Add(animal);
        
        return Created("", animal);
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id, [FromBody] Animal animal)
    {
        var animals = new MockDb().Animals;
        var animalToChange = animals.FirstOrDefault(x => x.Id == id);
        if (animalToChange == null)
        {
            return NotFound();
        }
        animalToChange = animal; 
        
        return Ok(animal);
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animals = new MockDb().Animals;
        var removed = animals.RemoveAll(x => x.Id == id);
        if (removed == 0)
        {
            return NotFound("Animal with this ID does not exist");
        }
        return Ok();
    }
}