
using Microsoft.AspNetCore.Mvc;
using TankToys.Models;
using TankToys.Services;

namespace TankToys.Controllers;

[ApiController]
[Route("[controller]")]
public class MapController : Controller
{
    [HttpGet]
    [Route("{id}")]
    public Map GetMapById(string id)
    {
        return MapService.GetMapById(id);
    }

    [HttpGet]
    public Map[] GetMapsByCreatorAddress(string address)
    {
        return MapService.GetMapsByCreatorAddress(address);
    }

    [HttpPost]
    public bool InsertMap(Map map){
        if (MapService.InsertMap(map)) {
            return true;
        }
        return false;
    }

    [HttpPut]
    public bool EditMap(Map map){
        if (MapService.EditMap(map)) {
            return true;
        }
        return false;
    }

    [HttpDelete]
    [Route("{id}")]
    public bool DeleteMap(int id)
    {
        if (MapService.DeleteMap(id)) {
            return true;
        }
        return false;
    }
}