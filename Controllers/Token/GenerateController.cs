using Microsoft.AspNetCore.Mvc;

namespace Mini_Securonix_API.Controllers;

[ApiController]
[Route("WS/Token/[controller]")]
public class GenerateController : ControllerBase
{

    private readonly ILogger<GenerateController> _logger;

    public GenerateController(ILogger<GenerateController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GenerateToken")]
    public string Get([FromHeader]string username, [FromHeader]string password, [FromHeader]int validity=365)
    {
        // Check Username + Password

        // Create new Token
        Token tok = new Token(username, validity);

        return tok.PrettyString();
    }
}
