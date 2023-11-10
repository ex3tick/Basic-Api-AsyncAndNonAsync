using Tutorial.Entitys;

namespace Tutorial.Services;

public class SuperPowerServices
{
    private readonly DataContext _context = new DataContext();

    public IEnumerable<SuperPower> SuperPowerGet()
    {
        return _context.SuperPowers.ToList();
    }

    public SuperPower SuperPowerPost(PostSuperPower_DTO postSuperPowerDto)
    {
        SuperPower superPower = new SuperPower();
        superPower.FightingSkill = postSuperPowerDto.FightingSkill;
        superPower.SuperPowerName = postSuperPowerDto.SuperPowerName;
        superPower.SuperHeroId = postSuperPowerDto.SuperHeroId;
        
        _context.SuperPowers.Add(superPower);
        _context.SaveChanges();
        return superPower;
    }

    public SuperPower SuperPowerPut(int id, PutSuperPower_DTO putSuperPowerDto)
    {
        SuperPower superPower = new SuperPower();
        superPower.SuperPowerName = putSuperPowerDto.SuperPowerName;
        superPower.FightingSkill = putSuperPowerDto.FightingSkill;
        superPower.SuperHeroId = putSuperPowerDto.SuperHeroId;

        superPower.SuperPowerId = id;
        _context.SuperPowers.Update(superPower);
        _context.SaveChanges();
        return superPower;

    }

    public SuperPower SuperPowerDelete(int id)
    {
        SuperPower superPower = new SuperPower();
        superPower.SuperPowerId = id;

        _context.SuperPowers.Remove(superPower);
        _context.SaveChanges();
        return superPower;
    }
    
    
}