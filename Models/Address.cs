
using Newtonsoft.Json;
using TankToys.Utils;

namespace TankToys.Models;

public class Address
{
    [JsonProperty("address")]
    public string address { get; set; }

    private Address(string address)
    {
        SetAddress(address);
    }

    public static Address Parse(string addresStr){
        try {
            return new Address(addresStr);
        } catch (Exception e) {
            return null;
        }
    }

    public string GetAddress() {
        if (address != null) {
            return address;
        } else {
            return null;
        }
    }

    public void SetAddress(string address)
    {
        if (AddressValidator.validate(address)) {
            this.address = address;
        } else {
            throw new Exception($"{address} is not a valid address");
        }
    }
}