using Microsoft.AspNetCore.Mvc;

namespace DC.SIF.BFF.Controllers;

public class ProductController : ControllerBase
{
    [HttpGet]
    [Route("GetProduct")]
    public IActionResult GetProduct()
    {
        return Ok();
    }
    
    [HttpGet]
    [Route("GetProduct/{id}")]
    public IActionResult GetProduct(string id)
    {
        return Ok();
    }
}