using DB=TankToys.Services.DatabaseService;
using TankToys.Models;

namespace TankToys.Services;

public static class MapService
{
    public static List<Map> GetAllMaps(){
        
        return null;
    }

    public static Map GetMapById(string id){
        Map map = new();
        DB.SelectByKey(map, id);
        return map;
    }

    public static bool InsertMap(Map map){
        return DB.Insert(map);
    }

    public static bool EditMap(Map map) {
        return DB.Update(map, map.Id);
    }

    public static bool DeleteMap(int id) {
        Map map = new();
        return DB.Delete(map, id);
    }

    public static Map[] GetMapsByCreatorAddress(string address) {
        // TODO Auto-generated method stub
       
        throw new NotImplementedException();
    }
}