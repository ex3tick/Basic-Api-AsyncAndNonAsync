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
    public IActionResult GetSuperPower()
    {
        return Ok(_services.SuperPowerGet());
    }

    [HttpPost]
    public IActionResult PostSuperPower(PostSuperPower_DTO postSuperPowerDto)
    {
        return Ok(_services.SuperPowerPost(postSuperPowerDto));
        
    }

    [HttpPut]
    public IActionResult PutSuperPower(int id, PutSuperPower_DTO putSuperPowerDto)
    {
        return Ok(_services.SuperPowerPut(id, putSuperPowerDto));
    }

    [HttpDelete]
    public IActionResult DeleteSuperPower(int id)
    {
        return Ok(_services.SuperPowerDelete(id));
    }
    
    
}