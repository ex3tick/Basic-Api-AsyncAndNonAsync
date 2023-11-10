using Tutorial.Entitys;

namespace Tutorial.Services;

public class SuperHeroServices
{
    private readonly DataContext _context = new DataContext();

    public IEnumerable<SuperHero> SuerpHeroGet()
    {
        return _context.SuperHeroes.ToList();
    }

    public SuperHero SuperHeroAdd(PostSuperHero_DTO postSuperHeroDto)
    {
        SuperHero superHero = new SuperHero();
        superHero.SuperHeroAge = postSuperHeroDto.SuperHeroAge;
        superHero.SuperHeroName = postSuperHeroDto.SuperHeroName;

        _context.SuperHeroes.Add(superHero);
        _context.SaveChanges();
        return superHero;
    }

    public SuperHero SuperHeroPut(int id, PutSuperHero_DTO putSuperHeroDto)
    {
        SuperHero superHero = new SuperHero();
        superHero.SuperHeroAge = putSuperHeroDto.SuperHeroAge;
        superHero.SuperHeroName = putSuperHeroDto.SuperHeroName;

        superHero.SuperHeroId = id;
        _context.SuperHeroes.Update(superHero);
        _context.SaveChanges();
        return superHero;
    }

    public SuperHero SuperHeroDelete(int id)
    {
        SuperHero superHero = new SuperHero();
        superHero.SuperHeroId = id;

        _context.SuperHeroes.Remove(superHero);
        _context.SaveChanges();
        return superHero;
    }
    
    
}