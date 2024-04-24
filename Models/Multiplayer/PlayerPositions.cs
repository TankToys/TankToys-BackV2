using Newtonsoft.Json;

namespace TankToys.Models.Multiplayer;

public class PlayerPositions
{
    [JsonProperty("xcoord")]
    public int xCoord { get; set; }

    [JsonProperty("ycoord")]
    public int yCoord { get; set; }

    
    public PlayerPositions(){

    }

    public PlayerPositions( int xCoord, int yCoord){
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
}