using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Tutorial.Entitys;

public class SuperPower
{
    [Key]
    public int SuperPowerId { get; set; }
    public string SuperPowerName { get; set; }
    public string FightingSkill { get; set; }
    
    public int SuperHeroId { get; set; }
    public SuperHero SuperHero { get; set; }
    
}