using Cw_06.Models;

namespace Cw_06.Repositories;

public interface IAnimalsRepository
{
    IEnumerable<Animal> FetchAnimals();
}