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

    public IEnumerable<Animal> GetAnimals()
    {
        var data = _animalsRepository.FetchAnimals();
        //Logika
        return data;
    }

    public int CreateAnimal(Animal animal)
    {
        //Logika
        //_animals.Add(animal);
        return 1;
    }
}