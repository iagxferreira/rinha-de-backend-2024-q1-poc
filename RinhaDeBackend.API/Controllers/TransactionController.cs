using Microsoft.AspNetCore.Mvc;

namespace RinhaDeBackend.API.Controllers
{
    [ApiController]
    public class TransactionController : ControllerBase
    {
        [HttpGet("/clientes/[id]/transacoes")]
        public async Task<IActionResult> Index([FromRoute] int id)
        {
            return Ok();
        }
    }
}
