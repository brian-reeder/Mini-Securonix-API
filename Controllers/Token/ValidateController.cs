using Microsoft.AspNetCore.Mvc;

namespace Mini_Securonix_API.Controllers;

[ApiController]
[Route("WS/Token/[controller]")]
public class ValidateController : ControllerBase
{

    private readonly ILogger<ValidateController> _logger;

    public ValidateController(ILogger<ValidateController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "ValidateToken")]
    public string Get([FromHeader]string token)
    {
        return "Validate Token!";
    }
}
