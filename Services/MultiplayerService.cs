
using TankToys.Models;

namespace TankToys.Services;

public class MultiplayerService(DatabaseService db, RoomService rooms)
{
    private readonly DatabaseService DB = db;

    private readonly RoomService Rooms = rooms;

    public string CreateRoom(Address host, GameModes gamemode)
    {
        List<string> guestList = [host.GetAddress()];

        var thisRoom = new Room 
        {
            Id = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString(),
            GuestList = guestList,
            Host = host.GetAddress(),
            GameMode = gamemode
        };
                
        return Rooms.InsertRoom(thisRoom) ? thisRoom.Id : "";
    }
    public bool AddGuestToRoom(string roomId, Address guest)
    {
        Room thisRoom = Rooms.GetRoomById(roomId);

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

        if (Rooms.EditRoom(thisRoom)) {
            return true;
        }
        return false;
    }

    public bool CloseRoom(object roomId, Address address)
    {
        throw new NotImplementedException();
    }

}