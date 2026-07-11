using Microsoft.AspNetCore.Mvc;
namespace ClienteAPI.Controllers;
[ApiController, Route("api/[controller]")]
public class ClientesDocumentoController : ControllerBase { [HttpGet] public IActionResult Get() => Ok(Array.Empty<object>()); }
