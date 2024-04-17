
using Microsoft.AspNetCore.Mvc;
using TankToys.Models;
using TankToys.Services;

namespace TankToys.Controllers;

[ApiController]
[Route("[controller]")]
public class MapController(MapService mapService) : Controller
{
    private readonly MapService _mapService;

    [HttpGet]
    [Route("{id}")]
    public Map GetMapById(string id)
    {
        return _mapService.GetMapById(id);
    }

    [HttpGet]
    public Map[] GetMapsByCreatorAddress(string address)
    {
        return _mapService.GetMapsByCreatorAddress(address);
    }

    [HttpPost]
    public bool InsertMap(Map map){
        if (_mapService.InsertMap(map)) {
            return true;
        }
        return false;
    }

    [HttpPut]
    public bool EditMap(Map map){
        if (_mapService.EditMap(map)) {
            return true;
        }
        return false;
    }

    [HttpDelete]
    [Route("{id}")]
    public bool DeleteMap(int id)
    {
        if (_mapService.DeleteMap(id)) {
            return true;
        }
        return false;
    }
}