
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using TankToys.Interfaces;

namespace TankToys.Models;

[Table("user")]
public class User : ITable 
{
    [Key]
    [JsonProperty("address")]
    public string Id { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("level")]
    public int Level { get; set; }

    [JsonProperty("profileImage")]
    public string ProfileImage { get; set; }

    public User()
    {

    }




}