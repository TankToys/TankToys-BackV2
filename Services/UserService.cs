
using TankToys.Models;
using DB=TankToys.Services.DatabaseService;

namespace TankToys.Services;

public static class UserService
{
    public static List<User> GetAllUsers()
    {
        return null;
    }

    public static User GetUserByAddress(string address)
    {
        User user = new User();
        DB.SelectByKey(user, address);
        if (user.Username == "default")
        {
            user.Username = null;
        }
        return user;
    }

    public static User GetUserByAddress(Address address)
    {
        User user = new User();
        DB.SelectByKey(user, address.GetAddress());
        if (user.Username == "default")
        {
            user.Username = null;
        }
        return user;
    }

    public static bool InsertUser(User user)
    {
        return DB.Insert(user);
    }

    public static bool EditUser(User user)
    {
        return DB.Update(user, user.Address);
    }

    public static bool DeleteUser(Address address)
    {
        User user = new User();
        return DB.Delete(user, address.GetAddress());
    }
}