using BFF.Api.Application.Commands.Tarefas.Criar;
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
        private readonly ICommandHandler<CriarTarefaCommand, ResponseMessage<Tarefa>> _commandHandler;

        public TarefaController(ICommandHandler<CriarTarefaCommand, ResponseMessage<Tarefa>> commandHandler)
        {
            _commandHandler = commandHandler;
        }

        [HttpPost]
        public async Task<IActionResult> CriarTarefa([FromBody] CriarTarefaCommand criarTarefa)
        {
            var resultado = await _commandHandler.Handle(criarTarefa);

            if (resultado.ValidationResult.IsValid)
                return Ok(resultado.Data);

            return BadRequest(resultado.ValidationResult.Errors);
        }
    }
}
