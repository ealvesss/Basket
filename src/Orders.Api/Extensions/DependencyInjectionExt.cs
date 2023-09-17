using basket_api.Service.Products.Interfaces;
using Orders.Domain.Service.ProductService;
using Orders.Infra.Interfaces;
using Orders.Infra.Repositories;

namespace basket_api.Extensions
{
    public static class DependencyInjectionExt
    {

        public static void InjectDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IImpactRepository, ImpactRepository>();
        }
    }
}
