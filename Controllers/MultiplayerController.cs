using Microsoft.AspNetCore.Mvc;
using TankToys.Models;
using TankToys.Models.Multiplayer;
using TankToys.Services;

namespace TankToys.Controllers;

[ApiController]
[Route("[controller]")]
public class MultiplayerController(ILogger<MultiplayerController> logger, MultiplayerService multiplayerService) : Controller
{
    private readonly ILogger<MultiplayerController> _logger = logger;
    private readonly MultiplayerService _multiplayerService = multiplayerService;

    [HttpPost]
    [Route("createRoom")]
    public string CreateRoom([FromBody]RoomBody body){
        return _multiplayerService.CreateRoom(Address.Parse(body.PlayerId), body.Gamemode);
    }

    [HttpPost]
    [Route("joinRoom")]
    public bool AddToRoom([FromBody]RoomBody body)
    {
        if (_multiplayerService.AddGuestToRoom(body.RoomId, Address.Parse(body.PlayerId))) {
            return true;
        }
        return false;
    }

    [HttpPost]
    [Route("leaveRoom")]
    public bool RemoveFromRoom([FromBody]RoomBody body)
    {
        if (_multiplayerService.RemoveGuestFromRoom(body.RoomId, Address.Parse(body.PlayerId)))
        {
            HttpContext.Response.StatusCode = 200;    
            return true;
        }
        HttpContext.Response.StatusCode = 400;
        return false;
    }

    [HttpPost]
    [Route("closeRoom")]
    public bool CloseRoom([FromBody]RoomBody body)
    {
        if (_multiplayerService.CloseRoom(body.RoomId, Address.Parse(body.PlayerId))) {
            return true;
        }  
        HttpContext.Response.StatusCode = 400;
        return false;
    }

    [HttpPost]
    [Route("data")]
    public RoomData Data([FromBody]RoomData room){
        if (_multiplayerService.GetRoom(room.Id) != null) {
			return _multiplayerService.ConductRoomData(room);
        }
        return null;
    }
}