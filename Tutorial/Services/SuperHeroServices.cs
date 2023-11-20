using Microsoft.EntityFrameworkCore;
using Tutorial.Entitys;
using Tutorial.Maps;

namespace Tutorial.Services;

public class SuperHeroServices
{
    private readonly DataContext _context = new DataContext();

    public async Task<IEnumerable<SuperHero>> SuerpHeroGet()
    {
        return await _context.SuperHeroes.ToListAsync();
    }

    public async Task<SuperHero> SuperHeroAdd(PostSuperHero_DTO postSuperHeroDto)
    {
        SuperHero superHero = SuperHeroMap.PostSuperHeroMap(postSuperHeroDto);
        _context.SuperHeroes.Add(superHero);
        await _context.SaveChangesAsync();
        return superHero;
    }
    public async Task<SuperHero> SuperHeroPut(int id, PutSuperHero_DTO putSuperHeroDto)
    {
        SuperHero superHero = SuperHeroMap.PutSuperHeroMap(id, putSuperHeroDto);
        _context.SuperHeroes.Update(superHero);
        await _context.SaveChangesAsync();
        return superHero;
    }

    public async Task<SuperHero> SuperHeroDelete(int id)
    {
        SuperHero superHero = new SuperHero();
        superHero.SuperHeroId = id;

        _context.SuperHeroes.Remove(superHero);
        await _context.SaveChangesAsync();
        return superHero;
    }
    
    
}