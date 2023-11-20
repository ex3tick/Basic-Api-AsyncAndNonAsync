using Microsoft.AspNetCore.Mvc;
using Tutorial.Entitys;
using Tutorial.Services;

namespace Tutorial.Controllers;
[ApiController]
[Route("SuperPower")]
public class SuperPowerController : ControllerBase
{
    private readonly SuperPowerServices _services = new SuperPowerServices();

    [HttpGet]
    public async Task<IActionResult> GetSuperPower()
    {
        return Ok(await _services.SuperPowerGet());
    }

    [HttpPost]
    public async Task<IActionResult> PostSuperPower(PostSuperPower_DTO postSuperPowerDto)
    {
        return Ok(await _services.SuperPowerPost(postSuperPowerDto));
        
    }

    [HttpPut]
    public async Task<IActionResult> PutSuperPower(int id, PutSuperPower_DTO putSuperPowerDto)
    {
        return Ok(await _services.SuperPowerPut(id, putSuperPowerDto));
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteSuperPower(int id)
    {
        return Ok(await _services.SuperPowerDelete(id));
    }
    
    
}