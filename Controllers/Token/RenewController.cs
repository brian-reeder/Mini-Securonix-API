using Microsoft.AspNetCore.Mvc;

namespace Mini_Securonix_API.Controllers;

[ApiController]
[Route("WS/Token/[controller]")]
public class RenewController : ControllerBase
{

    private readonly ILogger<RenewController> _logger;

    public RenewController(ILogger<RenewController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "RenewToken")]
    public string Get([FromHeader]string token)
    {
        return "Renew Token!";
    }
}
