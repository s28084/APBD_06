using Cw_06.Models;

namespace Cw_06.Services;

public interface IAnimalsService
{
    IEnumerable<Animal> GetAnimals(string orderBy = "Name");
    int CreateAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int idAnimal);
}