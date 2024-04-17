using TankToys.Models;

namespace TankToys.Services;

public class RoomService(DatabaseService db)
{
    private readonly DatabaseService DB = db;

    public Room GetRoomById(string id) {
        Room room = new() { Id = id, GuestList = [], Host = null, GameMode = GameModes.GAMEMODE3 };
        DB.SelectByKey<Room>(id);
        return room;
    }

    public bool InsertRoom(Room room){
        return DB.Insert(room) == 1;
    }

    public bool EditRoom(Room room) {
        return DB.Update(room, room.Id);
    }

    public bool DeleteRoom(Room room) {
        return DB.Delete(room) == 1;
    }
}