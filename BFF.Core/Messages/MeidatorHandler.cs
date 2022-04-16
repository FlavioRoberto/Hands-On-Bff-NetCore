using System;
using System.Threading.Tasks;

namespace BFF.Core.Messages
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IServiceProvider _serviceProvider;

        public MediatorHandler(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task<TResponse> Send<TCommand, TResponse>(TCommand request) where TCommand : IRequest<TResponse>
        {
            var commandHandler = (ICommandHandler<TCommand, TResponse>)_serviceProvider.GetService(typeof(ICommandHandler<TCommand, TResponse>));
            return await commandHandler.Handle(request);
        }
    }
}
