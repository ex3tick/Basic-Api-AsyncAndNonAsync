
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
    public async Task<IActionResult> GetSuperHero()
    {
        return Ok(await _services.SuerpHeroGet());
    }

    [HttpPost]
    public async Task<IActionResult> PostSuperHero(PostSuperHero_DTO postSuperHeroDto)
    {
        return Ok(await _services.SuperHeroAdd(postSuperHeroDto));
    }

    [HttpPut]
    public async Task<IActionResult> PutSuperHero(int id, PutSuperHero_DTO putSuperHeroDto)
    {
        return Ok(await _services.SuperHeroPut(id, putSuperHeroDto));
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteSuperHero(int id)
    {
        return Ok(await _services.SuperHeroDelete(id));

    }

}