using System.Threading.Tasks;

namespace BFF.Core.Messages
{
    public interface ICommandHandler<TCommand, TResponse> where TCommand : Command
    {
        public Task<TResponse> Handle(TCommand command);
    }
}
