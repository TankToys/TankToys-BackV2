using Newtonsoft.Json;

namespace TankToys.Models.Multiplayer;
public class RoomBody {
    
    [JsonProperty("roomId")]
    public string RoomId { get; set; }
    
    [JsonProperty("playerId")]
    public string PlayerId { get; set; }
    
    [JsonProperty("gamemode")]
    public GameModes Gamemode { get; set; }
}
