using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MSE.Clientes.API.Application.Commands;
using MSE.Clientes.API.Application.Events;
using MSE.Clientes.API.Data;
using MSE.Clientes.API.Data.Repository;
using MSE.Clientes.API.Models;
using MSE.Core.Mediator;
using MSE.WebAPI.Core.Usuario;

namespace MSE.Clientes.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            services.AddScoped<IMediatorHandler, MediatorHandler>();

            services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();
            services.AddScoped<IRequestHandler<AdicionarEnderecoCommand, ValidationResult>, ClienteCommandHandler>();

            services.AddScoped<INotificationHandler<ClienteRegistradoEvent>, ClienteEventHandler>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();
        }
    }
}