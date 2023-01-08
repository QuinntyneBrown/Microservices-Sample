using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace WebSPA.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class HomeController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    [HttpGet("summaries")]
    public async Task<IActionResult> Get()
    {
        return Ok(await Task.FromResult(Summaries));
    }
}
