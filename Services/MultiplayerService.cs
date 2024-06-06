using TankToys.Models;
using TankToys.Models.Multiplayer;

namespace TankToys.Services;

public class MultiplayerService(RoomService rooms)
{

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

    public Room GetRoom(string roomId)
    {
        var room = Rooms.GetRoomById(roomId);
        return room;
    }


    public bool AddGuestToRoom(string roomId, Address guest)
    {
        Room thisRoom = Rooms.GetRoomById(roomId);

        if (thisRoom == null) { return false; }
        if (thisRoom.Host == null) { return false; }
        if (thisRoom.GuestList.Count > 3) { return false; }

        if (thisRoom.GuestList.Contains(guest.GetAddress()))
        {
            return true;
        }

        thisRoom.GuestList.Add(guest.GetAddress());

        if (Rooms.EditRoom(thisRoom))
        {
            return true;
        }
        return false;
    }

    public bool RemoveGuestFromRoom(string roomId, Address guest)
    {
        Room thisRoom = Rooms.GetRoomById(roomId);

        if (thisRoom.Host == null)
        {
            return false;
        }

        if (thisRoom.GuestList.Contains(guest.GetAddress()))
        {
            thisRoom.GuestList.Remove(guest.GetAddress());
            Rooms.EditRoom(thisRoom);
            return true;
        }

        return false;
    }

    public bool CloseRoom(object roomId, Address address)
    {
        throw new NotImplementedException();
    }

    public RoomData ConductRoomData(RoomData roomData)
    {
        var room = Rooms.GetRoomData(roomData.Id);
        if (room == null)
        {
            Rooms.SetRoomData(roomData);
            return roomData;
        }
        room.PlayerPositions[roomData.PlayerPositions.Keys.First()] = roomData.PlayerPositions.Values.First();
        Rooms.SetRoomData(room);
        return room;
    }

}