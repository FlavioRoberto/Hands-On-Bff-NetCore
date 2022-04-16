using System.Threading.Tasks;

namespace BFF.Core.Messages
{
    public abstract class CommandHandler<TCommand, TResponse> : ICommandHandler<TCommand, TResponse> where TCommand : Command
    {
        public abstract Task<TResponse> Handle(TCommand command);
    }
}
