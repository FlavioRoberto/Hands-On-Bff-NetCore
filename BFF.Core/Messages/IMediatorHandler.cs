using System.Threading.Tasks;

namespace BFF.Core.Messages
{
    public interface IMediatorHandler 
    {
        Task<TResponse> Send<TCommand, TResponse>(TCommand request) where TCommand : IRequest<TResponse>;
    }
}
