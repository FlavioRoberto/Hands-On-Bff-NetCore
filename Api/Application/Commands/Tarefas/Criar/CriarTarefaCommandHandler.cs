using BFF.Core.Messages;
using BFF.Domain.Models;
using System.Threading.Tasks;

namespace BFF.Api.Application.Commands.Tarefas.Criar
{
    public class CriarTarefaCommandHandler : ICommandHandler<CriarTarefaCommand, ResponseMessage<Tarefa>>
    {
        public async Task<ResponseMessage<Tarefa>> Handle(CriarTarefaCommand command)
        {
            if (!command.EhValido())
                return ResponseMessageFactory.GerarErrorResponse<Tarefa>(command.ValidationResult);

            var tarefa = new Tarefa();

            return ResponseMessageFactory.GerarResponse(tarefa);
        }
    }
}
