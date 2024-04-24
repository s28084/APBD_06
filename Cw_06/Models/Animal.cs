using System.ComponentModel.DataAnnotations;

namespace Cw_06.Models;

public class Animal
{
    [Required]
    public int IdAnimal { get; set; }
    [Required]
    [MaxLength(200)]
    public String Name { get; set; }
    [MaxLength(200)]
    public String Description { get; set; }
    [Required]
    [MaxLength(200)]
    public String Category { get; set; }
    [Required]
    [MaxLength(200)]
    public String Area { get; set; }
    
}