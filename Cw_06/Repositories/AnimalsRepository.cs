using System.Data.SqlClient;
using Cw_06.Models;

namespace Cw_06.Repositories;

public class AnimalsRepository : IAnimalsRepository
{

    private IConfiguration _configuration;
    
    /* private static readonly List<Animal> _animals = new()
    {
        new Animal {IdAnimal = 1, Name = "Tiger", Description = "dangerous, orange", Category = "Exotic", Area = "Asia"},
        new Animal { IdAnimal = 2, Name = "Fox", Description = "orange", Category = "local", Area = "Europe"}
    }; */

    public AnimalsRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public IEnumerable<Animal> GetAnimals()
    {
        using var con = new SqlConnection(_configuration["ConnectionString:DefaultConnection"]);
        con.Open();

        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT "
    }

}