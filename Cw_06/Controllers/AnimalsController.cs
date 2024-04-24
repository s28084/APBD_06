using Microsoft.AspNetCore.Mvc;
using Cw_06.Models;
using Cw_06.Services;

namespace Cw_06.Controllers;

[Route("api/animals")]
[ApiController]
public class AnimalsController : ControllerBase
{
    private readonly IAnimalsService _animalService;
    
    public AnimalsController(IAnimalsService animalService)
    {
        _animalService = animalService;
    }

    [HttpGet]
    public IActionResult GetAnimals(String orderBy = "name")
    {
        var animal = _animalService.GetAnimals();
        return Ok(animal);
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        _animalService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    /*[HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var animalToEdit = _animals.FirstOrDefault(a => a.IdAnimal == id);

        if (animalToEdit == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        _animals.Remove(animalToEdit);
        _animals.Add(animal);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animalToRemove = _animals.FirstOrDefault(a => a.IdAnimal == id);
        if (animalToRemove == null)
        {
            return NoContent();
        }

        _animals.Remove(animalToRemove);
        return NoContent();
    }*/
    
    
}