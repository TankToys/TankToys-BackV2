using TankToys.Models;

namespace TankToys.Services;

public class MapService(DatabaseService db)
{
    private readonly DatabaseService DB = db;

    public List<Map> GetAllMaps(){
        
        return null;
    }

    public Map GetMapById(string id){
        Map map = new();
        DB.SelectByKey<Map>(id);
        return map;
    }

    public bool InsertMap(Map map){
        return DB.Insert(map) == 1;
    }

    public bool EditMap(Map map) {
        return DB.Update(map, map.Id);
    }

    public bool DeleteMap(int id) {
        Map map = new();
        return DB.Delete(map) ==  1;
    }

    public Map[] GetMapsByCreatorAddress(string address) {
        // TODO Auto-generated method stub
       
        throw new NotImplementedException();
    }
}