using Microsoft.AspNetCore.Mvc;

namespace UserAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet("/hello")]
    public IActionResult GetHello()
    {
        return Ok("Hello from UserAPI");
    }
}