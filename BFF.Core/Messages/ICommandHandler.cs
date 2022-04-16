using System.Threading.Tasks;

namespace BFF.Core.Messages
{
    public interface ICommandHandler<TCommand, TResponse> where TCommand : IRequest<TResponse>
    {
        public Task<TResponse> Handle(TCommand command);
    }
}
