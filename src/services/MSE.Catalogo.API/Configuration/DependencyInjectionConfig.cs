using Microsoft.Extensions.DependencyInjection;
using MSE.Catalogo.API.Data;
using MSE.Catalogo.API.Data.Repository;
using MSE.Catalogo.API.Models;

namespace MSE.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}