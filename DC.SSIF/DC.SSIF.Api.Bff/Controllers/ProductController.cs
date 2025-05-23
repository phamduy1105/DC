using Microsoft.AspNetCore.Mvc;

namespace DC.SSIF.Api.Bff.Controllers;

public class ProductController : ControllerBase
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
}