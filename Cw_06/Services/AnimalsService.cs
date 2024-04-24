using Cw_06.Models;

namespace Cw_06.Services;

public class AnimalsService : IAnimalsService
{
    private static readonly List<Animal> _animals = new()
    {
        new Animal {IdAnimal = 1, Name = "Tiger", Description = "dangerous, orange", Category = "Exotic", Area = "Asia"},
        new Animal { IdAnimal = 2, Name = "Fox", Description = "orange", Category = "local", Area = "Europe"}
    };

    public IEnumerable<Animal> GetAnimals()
    {
        //Logika
        return _animals;
    }

    public int CreateAnimal(Animal animal)
    {
        //Logika
        _animals.Add(animal);
        return 1;
    }
}