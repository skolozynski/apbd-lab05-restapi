using Microsoft.AspNetCore.Mvc;

namespace Lab_05_WebApi.Controllers;

[ApiController]
[Route("/animals-controllers")]
// animals-contreoller bo minimalapi ma animals
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetAnimalByID(int id)
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult AddAnimal()
    {
        return Created();
    }
}