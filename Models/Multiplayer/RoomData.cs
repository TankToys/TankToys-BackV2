using Newtonsoft.Json;

namespace TankToys.Models.Multiplayer;

public class RoomData
{   
    [JsonProperty("Id")]
    public string Id { get; set; }

    [JsonProperty("playerPositions")]
    public Dictionary<string,PlayerPositions> PlayerPositions { get; set; }

    public RoomData(){
            this.Id = "-1";
            this.PlayerPositions = [];
        }

    public RoomData(string roomid, Dictionary<string,PlayerPositions> playerPositions){
        this.Id = roomid;
        this.PlayerPositions = playerPositions;
    }

    public PlayerPositions GetPlayerPosition(string playerId){
        return PlayerPositions[playerId];
    }
    
    public string GetRoomId(){
        return this.Id;
    }
    
    public void SetRoomId(string roomId){
        this.Id = roomId;
    }
}