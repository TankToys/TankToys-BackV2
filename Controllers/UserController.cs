using Microsoft.AspNetCore.Mvc;
using TankToys.Models;
using TankToys.Services;
using TankToys.Utils;

namespace TankToys.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(ILogger<UserController> logger, UserService userService) : Controller
{
    private readonly ILogger<UserController> _logger = logger;
    private readonly UserService _userService = userService;

    [HttpGet]
    [Route("{address}")]
    public string GetUserByAddress(string address)
    {
        User user = _userService.GetUserByAddress(address);
		if (user.Username != null) {
            return JWT.GenerateJWTToken(user);
		}
		Response.StatusCode = 400;
        return null;
    }

    [HttpPost]
    public User InsertUser([FromBody]User requestUser)
    {
        if (_userService.InsertUser(requestUser)) {
            return requestUser;
        }
        Response.StatusCode = 400;
        return null;
    }

    [HttpPut]
    public User EditUser([FromBody]User requestUser)
    {
        if (_userService.EditUser(requestUser)) {
            return requestUser;
        }
        Response.StatusCode = 400;
        return null;
    }

    [HttpDelete]
    [Route("{address}")]
    public bool DeleteUser(Address address)
    {
        if (_userService.DeleteUser(address)) {
            return true;
        }
        Response.StatusCode = 400;
        return false;
    }
}