using BFF.Api.Application.Commands.Tarefas.Criar;
using BFF.Core.Messages;
using BFF.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace BFF.Api.Configurations
{
    public static class ApiConfiguration
    {
        public static void AddApiServices(this IServiceCollection services)
        {
          //  services.AddTransient(typeof(ICommandHandler<>), typeof(CommandHandler<>));

            services.AddTransient<ICommandHandler<CriarTarefaCommand, ResponseMessage<Tarefa>>, CriarTarefaCommandHandler>();
        }
    }
}
