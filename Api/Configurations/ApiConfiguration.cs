using BFF.Api.Application.Commands.Tarefas.Criar;
using BFF.Api.Application.ViewModels;
using BFF.Core.Messages;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace BFF.Api.Configurations
{
    public static class ApiConfiguration
    {
        public static void AddApiServices(this IServiceCollection services)
        {
            services.AddTransient(typeof(IMediatorHandler), typeof(MediatorHandler));
            services.AddTransient<ICommandHandler<CriarTarefaCommand, ResponseMessage<TarefaViewModel>>, CriarTarefaCommandHandler>();
        }
    }
}
