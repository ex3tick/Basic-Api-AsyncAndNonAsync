using Tutorial.Entitys;

namespace Tutorial.Maps;

public class SuperPowerMap
{
    public static SuperPower PostSuperPowerMap(PostSuperPower_DTO superPowerDto)
    {
        SuperPower superPower = new SuperPower();
        superPower.SuperPowerName = superPowerDto.SuperPowerName;
        superPower.FightingSkill = superPowerDto.FightingSkill;
        superPower.SuperHeroId = superPowerDto.SuperHeroId;
        return superPower;

    }

    public static SuperPower PutSuperPowerMap(int id, PutSuperPower_DTO putSuperPowerDto)
    {
        SuperPower superPower = new SuperPower();
        superPower.SuperPowerName = putSuperPowerDto.SuperPowerName;
        superPower.FightingSkill = putSuperPowerDto.FightingSkill;
        superPower.SuperHeroId = putSuperPowerDto.SuperHeroId;
        superPower.SuperPowerId = id;
        return superPower;
    }


}