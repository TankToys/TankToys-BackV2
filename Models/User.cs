
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace TankToys.Models;

[Table("user")]
public class User
{
    [Key]
    [JsonProperty("address")]
    public string Address { get; set; }

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