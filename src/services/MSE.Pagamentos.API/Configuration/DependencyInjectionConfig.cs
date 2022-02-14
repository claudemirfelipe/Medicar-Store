using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MSE.Pagamentos.API.Data;
using MSE.Pagamentos.API.Data.Repository;
using MSE.Pagamentos.API.Models;
using MSE.Pagamentos.API.Services;
using MSE.Pagamentos.CardAntiCorruption;
using MSE.Pagamentos.Facade;
using MSE.WebAPI.Core.Usuario;

namespace MSE.Pagamentos.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();

            services.AddScoped<IPagamentoService, PagamentoService>();
            services.AddScoped<IPagamentoFacade, PagamentoCartaoCreditoFacade>();

            services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            services.AddScoped<PagamentosContext>();
        }
    }
}