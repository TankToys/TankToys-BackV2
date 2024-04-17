using Microsoft.AspNetCore.Mvc;
using TankToys.Models;
using TankToys.Services;

namespace TankToys.Controllers;

[ApiController]
[Route("[controller]")]
public class TankController : Controller
{
    [HttpGet]
    [Route("{id}")]
    public Tank GetTankById(string id)
    {
        return TankService.GetTankById(id);
    }

    [HttpGet]
    [Route("creator/{address}")]
    public Tank[] GetTanksByCreatorAddress(string address)
    {
        return TankService.GetTanksByCreatorAddress(address);
    }

    [HttpGet]
    [Route("bullet/{bulletId}")]
    public Tank[] GetTanksByBullet(int bulletId)
    {
        return TankService.GetTanksByBullet(bulletId);
    }

    [HttpGet]
    [Route("cannon/{cannonId}")]
    public Tank[] GetTanksByCannon(int cannonId)
    {
        return TankService.GetTanksByCannon(cannonId);
    }

    [HttpGet]
    [Route("shell/{shellId}")]
    public Tank[] GetTanksByShell(int shellId)
    {
        return TankService.GetTanksByShell(shellId);
    }

    [HttpGet]
    [Route("trackWheel/{trackWheelId}")]
    public Tank[] GetTanksByTrackWheel(int trackWheelId)
    {
        return TankService.GetTanksByTrackWheel(trackWheelId);
    }

    [HttpPost]
    public bool InsertTank(Tank requestTank){
        if (TankService.InsertTank(requestTank)) {
            return true;
        }
		return false;
    }

    [HttpPut]
    public bool EditTank(Tank requestTank){
        if (TankService.EditTank(requestTank)) {
            return true;
        }
		return false;
    }

    [HttpDelete]
    [Route("{tankId}")]
    public bool DeleteTank(int tankId)
    {
        if (TankService.DeleteTank(tankId)) {
            return true;
        }
		return false;
    }
}