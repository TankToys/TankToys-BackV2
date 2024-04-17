using Microsoft.AspNetCore.Mvc;

namespace TankToys.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : Controller
{
    [HttpGet]
    [Route("{testString}")]
    public string GetUserByAddress(string testString)
    {
        return testString;
    }
}