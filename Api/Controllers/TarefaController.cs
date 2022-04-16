using BFF.Api.Application.Commands.Tarefas.Criar;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BFF.Api.Controllers
{
    [ApiController]
    [Route("tarefas")]
    public class TarefaController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CriarTarefa([FromBody] CriarTarefaCommand criarTarefa)
        {
            if (!criarTarefa.EhValido())
                return BadRequest(criarTarefa.ValidationResult);

            return Ok("Sucesso");
        }
    }
}
