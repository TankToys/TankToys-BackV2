
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using TankToys.Interfaces;

namespace TankToys.Models;

[Table("rooms")]
public class Room : ITable
{   
    [Key]
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("guestList")]
    public List<string> GuestList { get; set; }

    [JsonProperty("host")]
    public string Host { get; set; }

    [JsonProperty("gameMode")]
    public GameModes GameMode { get; set; }
}

public enum GameModes {
        _1V1,
        _PVP,
        GAMEMODE3
    }