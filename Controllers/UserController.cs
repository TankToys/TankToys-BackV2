using Microsoft.AspNetCore.Mvc;
using TankToys.Models;
using TankToys.Services;

namespace TankToys.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("{address}")]
    public string GetUserByAddress(string address)
    {
        User user = UserService.GetUserByAddress(address);
		if (user.Username != null) {
            //String k = CustomJWT.encode(user);
			//return k;
            return "Not implemented";
		}
		return null;
    }

    [HttpPost]
    public User InsertUser(User requestUser)
    {
        if (UserService.InsertUser(requestUser)) {
            return requestUser;
        }
        return null;
    }

    [HttpPut]
    public User EditUser(User requestUser)
    {
        if (UserService.EditUser(requestUser)) {
            return requestUser;
        }
        return null;
    }

    [HttpDelete]
    public bool DeleteUser(Address address)
    {
        if (UserService.DeleteUser(address)) {
            return true;
        }
        return false;
    }
}