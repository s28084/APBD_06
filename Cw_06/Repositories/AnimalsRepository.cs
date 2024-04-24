using Cw_06.Models;

namespace Cw_06.Repositories;

public class AnimalsRepository : IAnimalsRepository
{
    private static readonly List<Animal> _animals = new()
    {
        new Animal {IdAnimal = 1, Name = "Tiger", Description = "dangerous, orange", Category = "Exotic", Area = "Asia"},
        new Animal { IdAnimal = 2, Name = "Fox", Description = "orange", Category = "local", Area = "Europe"}
    };
    
    public IEnumerable<Animal> FetchAnimals()
    {
        return _animals;
    }
}