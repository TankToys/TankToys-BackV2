using TankToys.Models;

namespace TankToys.Services;

public class TankService(DatabaseService db)
{
    private readonly DatabaseService DB = db;

    public List<Tank> GetAllTanks(){
        return null;
    }
    
    public User JSONToTank(string tankString)
    {
        return null;
    }

    public Tank GetTankById(string id)
    {
        Tank tank = new();
        DB.SelectByKey<Tank>(id);
        return tank;
    }

    public Tank[] GetTanksByCreatorAddress(string creator)
    {
        Tank tank = new();
        return null;
    }

    public Tank[] GetTanksByBullet(int bulletId)
    {
        Tank tank = new();
        return null;
    }

    public Tank[] GetTanksByCannon(int cannonId)
    {
        Tank tank = new();
        return null;
    }

    public Tank[] GetTanksByShell(int shellId)
    {
        Tank tank = new();
        return null;
    }

    public Tank[] GetTanksByTrackWheel(int trackWheelId)
    {
        Tank tank = new();
        return null;
    }

    public bool InsertTank(Tank tank){
        return DB.Insert(tank) == 1;
    }

    public bool EditTank(Tank tank) {
        return DB.Update(tank, tank.Id);
    }

    public bool DeleteTank(int id)
     {
        Tank tank = new();
        return DB.Delete(tank) == 1;
    }
}