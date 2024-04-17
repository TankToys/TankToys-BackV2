
using TankToys.Models;

namespace TankToys.Services;

public static class MultiplayerService
{
    public static string CreateRoom(Address host, GameModes gamemode)
    {
        List<string> guestList = [host.GetAddress()];

        var thisRoom = new Room 
        {
            Id = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString(),
            GuestList = guestList,
            Host = host.GetAddress(),
            GameMode = gamemode
        };
                
        return RoomService.InsertRoom(thisRoom) ? thisRoom.Id : "";
    }
    public static bool AddGuestToRoom(string roomId, Address guest)
    {
        Room thisRoom = RoomService.GetRoomById(roomId);

        if (thisRoom.Host == null) {
            return false;
        }

        if (thisRoom.GuestList.Count > 3) {
            return false;
        }

        if (thisRoom.GuestList.Contains(guest.GetAddress())) {
            return true;
        }

        thisRoom.GuestList.Add(guest.GetAddress());

        if (RoomService.EditRoom(thisRoom)) {
            return true;
        }
        return false;
    }

    public static bool CloseRoom(object roomId, Address address)
    {
        throw new NotImplementedException();
    }

}