using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using TankToys.Interfaces;

namespace TankToys.Models.Multiplayer;

[Table("room_data")]
public class RoomDataTable : ITable
{   
    [Key]
    [JsonProperty("Id")]
    public string Id { get; set; }

    [JsonProperty("playerPositions")]
    public string PlayerPositions { get; set; }
    
}