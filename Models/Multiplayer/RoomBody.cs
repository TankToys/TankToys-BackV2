using Newtonsoft.Json;

namespace TankToys.Models.Multiplayer;
public class RoomBody {
    
    [JsonProperty("roomId")]
    public string RoomId;
    
    [JsonProperty("playerId")]
    public string PlayerId;
    
    [JsonProperty("gamemode")]
    public GameModes Gamemode;
}
