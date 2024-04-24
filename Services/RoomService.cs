using Newtonsoft.Json;
using TankToys.Models;
using TankToys.Models.Multiplayer;

namespace TankToys.Services;

public class RoomService(DatabaseService db)
{
    private readonly DatabaseService DB = db;

    public Room GetRoomById(string id) {
        var room = DB.SelectByKey<Room>(id);
        return room;
    }

    public bool InsertRoom(Room room){
        return DB.Insert(room) == 1;
    }

    public bool EditRoom(Room room) {
        return DB.Update(room) == 1;
    }

    public bool DeleteRoom(Room room) {
        return DB.Delete(room) == 1;
    }


    public void SetRoomData(RoomData roomData) 
    {
        var strPositions = JsonConvert.SerializeObject(roomData.PlayerPositions);
        DB.Insert(new RoomDataTable{ Id = roomData.Id, PlayerPositions = strPositions});
    }

    public RoomData GetRoomData(string roomId) 
    {
        var roomData = DB.SelectByKey<RoomDataTable>(roomId);
        if (roomData == null)
        {
            return null;
        }
        var positions = JsonConvert.DeserializeObject<Dictionary<string,PlayerPositions>>(roomData.PlayerPositions);
        return new RoomData(roomId, positions);
    }
}