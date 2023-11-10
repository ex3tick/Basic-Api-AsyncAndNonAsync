
using Microsoft.AspNetCore.Mvc;
using Tutorial.Entitys;
using Tutorial.Services;

namespace Tutorial.Controllers;

[ApiController]
[Route("SuperHero")]
public class SuperHeroController : ControllerBase
{
    private readonly SuperHeroServices _services = new SuperHeroServices();

    [HttpGet]
    public IActionResult GetSuperHero()
    {
        return Ok(_services.SuerpHeroGet());
    }

    [HttpPost]
    public IActionResult PostSuperHero(PostSuperHero_DTO postSuperHeroDto)
    {
        return Ok(_services.SuperHeroAdd(postSuperHeroDto));
    }

    [HttpPut]
    public IActionResult PutSuperHero(int id, PutSuperHero_DTO putSuperHeroDto)
    {
        return Ok(_services.SuperHeroPut(id, putSuperHeroDto));
    }

    [HttpDelete]
    public IActionResult DeleteSuperHero(int id)
    {
        return Ok(_services.SuperHeroDelete(id));

    }

}