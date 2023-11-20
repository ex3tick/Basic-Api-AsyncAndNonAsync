using Tutorial.Entitys;

namespace Tutorial.Maps;

public class SuperHeroMap
{
    public static SuperHero PostSuperHeroMap(PostSuperHero_DTO postSuperHeroDto)
    {
        SuperHero superHero = new SuperHero();
        superHero.SuperHeroName = postSuperHeroDto.SuperHeroName;
        superHero.SuperHeroAge = postSuperHeroDto.SuperHeroAge;
        return superHero;
    }

    public static SuperHero PutSuperHeroMap(int id, PutSuperHero_DTO putSuperHeroDto)
    {
        SuperHero superHero = new SuperHero();
        superHero.SuperHeroName = putSuperHeroDto.SuperHeroName;
        superHero.SuperHeroAge = putSuperHeroDto.SuperHeroAge;
        superHero.SuperHeroId = id;
        return superHero;

    }

}