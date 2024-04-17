using Microsoft.AspNetCore.Mvc;
using TankToys.Models;
using TankToys.Services;

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
            //String k = CustomJWT.encode(user);
			//return k;
            return "Not implemented";
		}
		return null;
    }

    [HttpPost]
    public User InsertUser([FromBody]User requestUser)
    {
        if (_userService.InsertUser(requestUser)) {
            return requestUser;
        }
        return null;
    }

    [HttpPut]
    public User EditUser([FromBody]User requestUser)
    {
        if (_userService.EditUser(requestUser)) {
            return requestUser;
        }
        return null;
    }

    [HttpDelete]
    [Route("{address}")]
    public bool DeleteUser(Address address)
    {
        if (_userService.DeleteUser(address)) {
            return true;
        }
        return false;
    }
}