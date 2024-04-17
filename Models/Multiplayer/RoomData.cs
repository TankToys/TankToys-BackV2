
using Newtonsoft.Json;

namespace TankToys.Models.Multiplayer;

public class RoomData
{
    [JsonProperty("roomId")]
    public int RoomId { get; set; }

    [JsonProperty("playerPositions")]
    public List<PlayerPositions> PlayerPositions { get; set; }

    public RoomData(){
            this.RoomId = -1;
            this.PlayerPositions = [new PlayerPositions()];
        }

    public RoomData(int roomid, List<PlayerPositions> playerPositions){
        this.RoomId = roomid;
        this.PlayerPositions = playerPositions;
    }

    public PlayerPositions GetPlayerPosition(string playerId){
        foreach (var playerPosition in PlayerPositions)
        {
            if (playerPosition.GetPlayerId() == playerId) {
                return playerPosition;
            }
        }

        return null;
    }
    
    public int GetRoomId(){
        return this.RoomId;
    }
    
    public void SetRoomId(int roomId){
        this.RoomId = roomId;
    }
}