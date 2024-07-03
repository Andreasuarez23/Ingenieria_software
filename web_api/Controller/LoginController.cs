using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]

public class LoginController : ControllerBase
{

    public LoginController(ILogger<LoginController>logger)
    {
        _logger = logger
    }

    [HttpGet(Name = "LoginController")]
    public IEnumerable<LoginController>Get()
    {
        return Summaries;
    }

}


