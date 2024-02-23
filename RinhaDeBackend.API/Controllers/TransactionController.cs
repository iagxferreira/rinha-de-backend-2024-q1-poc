using Microsoft.AspNetCore.Mvc;
using RinhaDeBackend.API.ViewModels.Client;

namespace RinhaDeBackend.API.Controllers
{
    [ApiController]
    public class TransactionController : ControllerBase
    {
        [HttpPost("/clientes/{id:int}/transacoes")]
        public async Task<IActionResult> GetTransactions(
            [FromRoute] int id,
            [FromBody] CreateClientTransactionRequest body
            )
        {
            return Ok(new CreateClientTransactionResponse());
        }

        [HttpGet("/clientes/{id:int}/extrato")]
        public async Task<IActionResult> GetReports(
            [FromRoute] int id,
            [FromBody] CreateClientTransactionRequest body
        )
        {
            return Ok(new ClientReportResponse());
        }
    }
}
