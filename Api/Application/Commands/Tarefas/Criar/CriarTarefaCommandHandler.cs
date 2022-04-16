using BFF.Core.Messages;
using BFF.Core.Validators;
using BFF.Domain.Models;
using System.Threading.Tasks;

namespace BFF.Api.Application.Commands.Tarefas.Criar
{
    public class ResponseMessage<T>
    {
        public ValidationResult ValidationResult { get; private set; }
        public T Data { get; set; }

        public ResponseMessage(ValidationResult validationResult)
        {
            ValidationResult = validationResult;
        }

        public ResponseMessage(T data)
        {
            ValidationResult = new ValidationResult();
            Data = data;
        }

    }

    public static class ResponseMessageFactory
    {
        public static ResponseMessage<T> GerarErrorResponse<T>(ValidationResult validationResult)
        {
            return new ResponseMessage<T>(validationResult);
        }

        public static ResponseMessage<T> GerarResponse<T>(T data)
        {
            return new ResponseMessage<T>(data);
        }
    }


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
