
using Newtonsoft.Json;

namespace TankToys.Models.Multiplayer;

public class PlayerPositions
{
    [JsonProperty("playerId")]
    private string playerId { get; set; }

    [JsonProperty("xcoord")]
    private int xCoord { get; set; }

    [JsonProperty("ycoord")]
    private int yCoord { get; set; }

    
    public PlayerPositions(){
        this.playerId = "testPlayer";
        this.xCoord = 45;
        this.yCoord = 34;
    }

    public PlayerPositions(string playerId, int xCoord, int yCoord){
        this.playerId = playerId;
        this.xCoord = xCoord;
        this.yCoord = yCoord;
    }


    public int GetYcoord(){
        return this.yCoord;
    }
    
    public void SetYcoord(int ycoord){
        this.yCoord = ycoord;
    }
    public int Getxcoord(){
        return this.xCoord;
    }
    
    public void Setxcoord(int xcoord){
        this.xCoord = xcoord;
    }
    public string GetPlayerId(){
        return this.playerId;
    }
    
    public void SetPlayerId(string playerId){
        this.playerId = playerId;
    }
}