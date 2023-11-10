using System.ComponentModel.DataAnnotations;

namespace Tutorial.Entitys;

public class SuperHero
{
    [Key]
    public int SuperHeroId { get; set; }
    
    public string SuperHeroName { get; set; }
    
    public int SuperHeroAge { get; set; }
    
    public List<SuperPower>SuperPowers { get; set; }
}