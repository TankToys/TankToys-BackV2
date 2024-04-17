using Microsoft.AspNetCore.Mvc;
using TankToys.Models;
using TankToys.Models.Multiplayer;
using TankToys.Services;

namespace TankToys.Controllers;

[ApiController]
[Route("[controller]")]
public class MultiplayerController : Controller
{
    private readonly ILogger<MultiplayerController> _logger;

    public MultiplayerController(ILogger<MultiplayerController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    [Route("createRoom")]
    public string CreateRoom(RoomBody body){
        return MultiplayerService.CreateRoom(Address.Parse(body.PlayerId), body.Gamemode);
    }

    [HttpPost]
    [Route("joinRoom")]
    public bool AddToRoom(RoomBody body)
    {
        if (MultiplayerService.AddGuestToRoom(body.RoomId, Address.Parse(body.PlayerId))) {
            return true;
        }
        return false;
    }

    [HttpPost]
    [Route("leaveRoom")]
    public bool RemoveFromRoom(RoomBody body)
    {
        return false;
    }

    [HttpPost]
    [Route("closeRoom")]
    public bool CloseRoom(RoomBody body)
    {
        if (MultiplayerService.CloseRoom(body.RoomId, Address.Parse(body.PlayerId))) {
            return true;
        }  
        return false;
    }

    [HttpPost]
    [Route("data/{roomId}")]
    public bool Data(string roomId, RoomData room){
        if (room.GetRoomId() != -1) { // good room
			_logger.LogDebug(roomId);
        }
        return false;
    }
}