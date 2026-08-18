using Microsoft.AspNetCore.Mvc;

namespace backend_app.Controllers;

[ApiController]
[Route("[controller]")]
public class IstrazivackiRadController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello from IstrazivackiRadController!");
    }
}
