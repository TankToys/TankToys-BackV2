
using TankToys.Models;

namespace TankToys.Services;

public class UserService(DatabaseService db)
{
    private readonly DatabaseService DB = db;

    public List<User> GetAllUsers()
    {
        return null;
    }

    public User GetUserByAddress(string address)
    {
        User user = new();
        user = DB.SelectByKey<User>(address);
        if (user.Username == "default")
        {
            user.Username = null;
        }
        return user;
    }

    public User GetUserByAddress(Address address)
    {
        User user = new User();
        DB.SelectByKey<User>(address.GetAddress());
        if (user.Username == "default")
        {
            user.Username = null;
        }
        return user;
    }

    public bool InsertUser(User user)
    {
        return DB.Insert(user) == 1;
    }

    public bool EditUser(User user)
    {
        return DB.Update(user) == 1;
    }

    public bool DeleteUser(Address address)
    {
        User user = new User();
        return DB.Delete(user) == 1;
    }
}