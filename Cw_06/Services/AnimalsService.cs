using Cw_06.Models;
using Cw_06.Repositories;

namespace Cw_06.Services;

public class AnimalsService : IAnimalsService
{

    private readonly IAnimalsRepository _animalsRepository;
    
    public AnimalsService(IAnimalsRepository animalsRepository)
    {
        _animalsRepository = animalsRepository;
    }

    public IEnumerable<Animal> GetAnimals(string orderBy = "Name")
    {
        var data = _animalsRepository.GetAnimals();
        //Logika
        return data;
    }

    public int CreateAnimal(Animal animal)
    {
        //Logika
        return _animalsRepository.CreateAnimal(animal);
    }

    public int UpdateAnimal(Animal animal)
    {
        //Logika
        return _animalsRepository.UpdateAnimal(animal);
    }

    public int DeleteAnimal(int idAnimal)
    {
        //Logika
        return _animalsRepository.DeleteAnimal(idAnimal);
    }
}