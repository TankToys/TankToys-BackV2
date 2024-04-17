using Microsoft.AspNetCore.Mvc;
using TankToys.Models;
using TankToys.Services;

namespace TankToys.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController(DatabaseService db) : Controller
{
    private readonly DatabaseService DB = db;

    [HttpGet]
    [Route("{testString}")]
    public string GetUserByAddress(string testString)
    {
        DB.SelectByKey<User>("0x0000000000000000000000000000000000000000");
        return testString;
    }
}