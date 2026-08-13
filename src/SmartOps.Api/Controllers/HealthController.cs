using Microsoft.AspNetCore.Mvc;

namespace SmartOps.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            status = "healthy",
            service = "SmartOps API"
        });
    }
}