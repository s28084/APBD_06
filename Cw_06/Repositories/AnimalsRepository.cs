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
    
    public IEnumerable<Animal> GetAnimals(string orderBy = "Name")
    {
        if ((orderBy != "IdAnimal") && (orderBy != "Description") && (orderBy != "Category") && (orderBy != "Area"))
        {
            orderBy = "Name";
        }
        
        using var con = new SqlConnection(_configuration["ConnectionString:DefaultConnection"]);
        con.Open();

        using var cmd = new SqlCommand();
        cmd.Connection = con;

        cmd.CommandText = "SELECT IdAnimal, Name, Description, Category, Area FROM Animal ORDER BY {orderBy}";

        var dr = cmd.ExecuteReader();
        var animals = new List<Animal>();
        while (dr.Read())
        {
            var animal = new Animal
            {
                IdAnimal = (int)dr["IdAnimal"],
                Name = dr["Name"].ToString(),
                Description = dr["Description"].ToString(),
                Category = dr["Category"].ToString(),
                Area = dr["Area"].ToString()
            };
            animals.Add(animal);
        }

        return animals;
    }

    public IEnumerable<Animal> GetAnimals()
    {
        throw new NotImplementedException();
    }

    public int CreateAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }

    public int UpdateAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }

    public int DeleteAnimal(int idAnimal)
    {
        throw new NotImplementedException();
    }
}