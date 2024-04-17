using TankToys.Database;
using TankToys.Models;

namespace TankToys.Services;

public static class DatabaseService
{
    public static bool Delete<T>(T model)
    {
        var ctx = new AppDbContext();
        throw new NotImplementedException();
    }

    public static bool Insert(object room)
    {
        var ctx = new AppDbContext();
        ctx.Users.Add(new User());
        ctx.SaveChanges();
        return true;
    }

    public static void SelectByKey(object room, string id)
    {
        throw new NotImplementedException();
    }
    
    public static Tank[] SelectByKey(Tank tank, string v, int trackWheelId)
    {
        throw new NotImplementedException();
    }

    public static Tank[] SelectByKey(Tank tank, string v, string trackWheelId)
    {
        throw new NotImplementedException();
    }

    public static bool Update(object room, object value)
    {
        throw new NotImplementedException();
    }

    
}