using Orders.Application.Services;
using Orders.Application.Services.Interfaces;
using Orders.Domain.Interfaces;
using Orders.Domain.Products.Interfaces;
using Orders.Domain.Service.ProductService;
using Orders.Infra.Repositories;
using Orders.Infra.Util;
using Orders.Infra.Util.Interfaces;

namespace Orders.Api.Extensions
{
    public static class DependencyInjectionExt
    {

        public static void InjectDependencies(this IServiceCollection services)
        {
            //scoped, transient, singleton
            //singleton: uma instancia para toda a aplicação
            //scoped: uma instancia para cada request
            //transient: uma instancia para cada injeção de dependencia

            services.AddScoped<IProductAppService, ProductAppService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductClient, ProductClient>();
            services.AddScoped<ISupportMethods, SupportMethods>();
        }
    }
}
