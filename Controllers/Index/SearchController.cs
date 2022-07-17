using Microsoft.AspNetCore.Mvc;

namespace Mini_Securonix_API.Controllers;

[ApiController]
[Route("WS/Index/[controller]")]
public class SearchController : ControllerBase
{

    private readonly ILogger<SearchController> _logger;

    public SearchController(ILogger<SearchController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Search")]
    public string Get([FromHeader]string token, string query)
    {
        return $"Search Index!\n{query}";
    }
}
