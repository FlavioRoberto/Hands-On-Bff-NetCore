using BFF.Api.Application.ViewModels;
using BFF.Core.Messages;
using BFF.Domain.Models;
using System.Threading.Tasks;

namespace BFF.Api.Application.Commands.Tarefas.Criar
{
    public class CriarTarefaCommandHandler : ICommandHandler<CriarTarefaCommand, ResponseMessage<TarefaViewModel>>
    {
        public async Task<ResponseMessage<TarefaViewModel>> Handle(CriarTarefaCommand command)
        {
            if (!command.EhValido())
                return ResponseMessageFactory.GerarErrorResponse<TarefaViewModel>(command.ValidationResult);

            var tarefa = new TarefaViewModel();

            return ResponseMessageFactory.GerarResponse(tarefa);
        }
    }
}
