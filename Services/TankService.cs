using TankToys.Models;
using DB=TankToys.Services.DatabaseService;

namespace TankToys.Services;

public static class TankService
{
    public static List<Tank> GetAllTanks(){
        return null;
    }
    
    public static User JSONToTank(String tankString)
    {
        return null;
    }

    public static Tank GetTankById(string id)
    {
        Tank tank = new();
        DB.SelectByKey(tank, id);
        return tank;
    }

    public static Tank[] GetTanksByCreatorAddress(string creator)
    {
        Tank tank = new();
        return (Tank[])DB.SelectByKey(tank, "creator", creator);
    }

    public static Tank[] GetTanksByBullet(int bulletId)
    {
        Tank tank = new();
        return (Tank[])DB.SelectByKey(tank, "bullet", bulletId);
    }

    public static Tank[] GetTanksByCannon(int cannonId)
    {
        Tank tank = new();
        return (Tank[])DB.SelectByKey(tank, "cannon", cannonId);
    }

    public static Tank[] GetTanksByShell(int shellId)
    {
        Tank tank = new();
        return (Tank[])DB.SelectByKey(tank, "shell", shellId);
    }

    public static Tank[] GetTanksByTrackWheel(int trackWheelId)
    {
        Tank tank = new();
        return (Tank[])DB.SelectByKey(tank, "trackwheel", trackWheelId);
    }

    public static bool InsertTank(Tank tank){
        return DB.Insert(tank);
    }

    public static bool EditTank(Tank tank) {
        return DB.Update(tank, tank.Id);
    }

    public static bool DeleteTank(int id)
     {
        Tank tank = new();
        return DB.Delete(tank, id);
    }
}