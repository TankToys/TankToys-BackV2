using TankToys.Models;
using DB=TankToys.Services.DatabaseService;

namespace TankToys.Services;

public static class RoomService
{
    public static Room GetRoomById(string id) {
        Room room = new() { Id = id, GuestList = [], Host = null, GameMode = GameModes.GAMEMODE3 };
        DB.SelectByKey(room, id);
        return room;
    }

    public static bool InsertRoom(Room room){
        return DB.Insert(room);
    }

    public static bool EditRoom(Room room) {
        return DB.Update(room, room.Id);
    }

    public static bool DeleteRoom(Room room) {
        return DB.Delete(room, room.Id);
    }
}