using Microsoft.AspNetCore.Mvc;
using TankToys.Models;
using TankToys.Services;

namespace TankToys.Controllers;

[ApiController]
[Route("[controller]")]
public class TankController(TankService tankService) : Controller
{
    private readonly TankService _tankService = tankService;

    [HttpGet]
    [Route("{id}")]
    public Tank GetTankById(string id)
    {
        return _tankService.GetTankById(id);
    }

    [HttpGet]
    [Route("creator/{address}")]
    public Tank[] GetTanksByCreatorAddress(string address)
    {
        return _tankService.GetTanksByCreatorAddress(address);
    }

    [HttpGet]
    [Route("bullet/{bulletId}")]
    public Tank[] GetTanksByBullet(int bulletId)
    {
        return _tankService.GetTanksByBullet(bulletId);
    }

    [HttpGet]
    [Route("cannon/{cannonId}")]
    public Tank[] GetTanksByCannon(int cannonId)
    {
        return _tankService.GetTanksByCannon(cannonId);
    }

    [HttpGet]
    [Route("shell/{shellId}")]
    public Tank[] GetTanksByShell(int shellId)
    {
        return _tankService.GetTanksByShell(shellId);
    }

    [HttpGet]
    [Route("trackWheel/{trackWheelId}")]
    public Tank[] GetTanksByTrackWheel(int trackWheelId)
    {
        return _tankService.GetTanksByTrackWheel(trackWheelId);
    }

    [HttpPost]
    public bool InsertTank(Tank requestTank){
        if (_tankService.InsertTank(requestTank)) {
            return true;
        }
		return false;
    }

    [HttpPut]
    public bool EditTank(Tank requestTank){
        if (_tankService.EditTank(requestTank)) {
            return true;
        }
		return false;
    }

    [HttpDelete]
    [Route("{tankId}")]
    public bool DeleteTank(int tankId)
    {
        if (_tankService.DeleteTank(tankId)) {
            return true;
        }
		return false;
    }
}