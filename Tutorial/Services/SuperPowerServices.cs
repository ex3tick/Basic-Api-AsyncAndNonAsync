using Microsoft.EntityFrameworkCore;
using Tutorial.Entitys;
using Tutorial.Maps;

namespace Tutorial.Services;

public class SuperPowerServices
{
    private readonly DataContext _context = new DataContext();

    public async Task<IEnumerable<SuperPower>> SuperPowerGet()
    {
        return await _context.SuperPowers.ToListAsync();
    }

    public async Task<SuperPower> SuperPowerPost(PostSuperPower_DTO postSuperPowerDto)
    {
        SuperPower superPower = SuperPowerMap.PostSuperPowerMap(postSuperPowerDto);
        _context.SuperPowers.Add(superPower);
        await _context.SaveChangesAsync();
        return superPower;
    }

    public async Task<SuperPower> SuperPowerPut(int id, PutSuperPower_DTO putSuperPowerDto)
    {
        SuperPower superPower = SuperPowerMap.PutSuperPowerMap(id, putSuperPowerDto);
        _context.SuperPowers.Update(superPower);
        await _context.SaveChangesAsync();
        return superPower;

    }

    public async Task<SuperPower> SuperPowerDelete(int id)
    {
        SuperPower superPower = new SuperPower();
        superPower.SuperPowerId = id;

        _context.SuperPowers.Remove(superPower);
        await _context.SaveChangesAsync();
        return superPower;
    }
    
    
}