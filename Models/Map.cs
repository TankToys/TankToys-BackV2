using Newtonsoft.Json;

namespace TankToys.Models;

public class Map
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("arrMap")]
    public ArrayMap ArrMap { get; set; }

    [JsonProperty("creator")]
    public Address Creator { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}

public class ArrayMap {
    [JsonProperty("positions")]
    public string[] Positions { get; set; }

    public ArrayMap(string[] positions)
    {
        SetPositions(positions);
    }

    public String[] GetPositions() {
        if (this.Positions != null) {
            return this.Positions;
        } else {
            return null;
        }
    }

    public void SetPositions(string[] positions)
    {
        this.Positions = positions;
    }
}