using Newtonsoft.Json;
using TankToys.Interfaces;

namespace TankToys.Models;

public class Tank : ITable
{
    [JsonProperty("id")]
    public string Id  { get; set; }

    [JsonProperty("bullet")]
    public Bullet Bullet  { get; set; }

    [JsonProperty("cannon")]
    public Cannon Cannon  { get; set; }

    [JsonProperty("shell")]
    public Shell Shell  { get; set; }

    [JsonProperty("trackWheels")]
    public TrackWheels TrackWheels  { get; set; }

    [JsonProperty("name")]
    public string Name  { get; set; }

    [JsonProperty("creator")]
    public Address Creator  { get; set; }
}

public class Bullet
{
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("speed")]
    public int Speed { get; set; }
    [JsonProperty("dmg")]
    public int Dmg { get; set; }
    [JsonProperty("bounces")]
    public int Bounces { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("type")]
    public string Type { get; set; }
}

public class Cannon
{
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("reloadSpeed")]
    public int ReloadSpeed { get; set; }
    [JsonProperty("ammo")]
    public int Ammo { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("bulletType")]
    public string BulletType { get; set; }
}

public class Shell
{
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("hp")]
    public int Hp { get; set; }
    [JsonProperty("type")]
    public string Type { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
}

public class TrackWheels
{
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("speed")]
    public int Speed { get; set; }
    [JsonProperty("terrain")]
    public string Terrain { get; set; }
    [JsonProperty("trackOrWheel")]
    public string TrackOrWheel { get; set; }
    [JsonProperty("tankType")]
    public string TankType { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
}