using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MSE.Clientes.API.Services;
using MSE.Core.Utils;
using MSE.MessageBus;

namespace MSE.Clientes.API.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"))
                .AddHostedService<RegistroClienteIntegrationHandler>();
        }
    }
}