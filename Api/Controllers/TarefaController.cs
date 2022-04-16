using BFF.Api.Application.Commands.Tarefas.Criar;
using BFF.Api.Application.ViewModels;
using BFF.Core.Messages;
using BFF.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BFF.Api.Controllers
{
    [ApiController]
    [Route("tarefas")]
    public class TarefaController : ControllerBase
    {
        private readonly IMediatorHandler _commandHandler;

        public TarefaController(IMediatorHandler commandHandler)
        {
            _commandHandler = commandHandler;
        }

        [HttpPost]
        public async Task<IActionResult> CriarTarefa([FromBody] CriarTarefaCommand criarTarefa)
        {
            var resultado = await _commandHandler.Send<CriarTarefaCommand, ResponseMessage<TarefaViewModel>>(criarTarefa);

            if (resultado.ValidationResult.IsValid)
                return Ok(resultado.Data);

            return BadRequest(resultado.ValidationResult.Errors);
        }
    }
}
