using Microsoft.AspNetCore.Mvc;
namespace ClienteAPI.Controllers;
[ApiController, Route("api/[controller]")]
public class ClientesController : ControllerBase { [HttpGet] public IActionResult Get() => Ok(Array.Empty<object>()); }
