
using System.Text.RegularExpressions;

namespace TankToys.Utils;

public class AddressValidator 
{

    private static readonly string Expression = "^0x[a-fA-F0-9]{40}$";

    public static bool validate(string addr) {
        Match m = Regex.Match(addr, Expression, RegexOptions.IgnoreCase);
        if (m.Success) {
            return true;
        }
        return false;
    }

}