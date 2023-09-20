using Basket.Application.Services;
using Basket.Application.Services.Interfaces;
using Basket.Domain.Interfaces;
using Basket.Domain.Products.Interfaces;
using Basket.Domain.Service.ProductService;
using Basket.Domain.Util;
using Basket.Domain.Util.Interfaces;
using Basket.Infra.Repositories;

namespace Basket.Api.Extensions
{
    public static class DependencyInjectionExt
    {

        public static void InjectDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductAppService, ProductAppService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepo, ProductRepo>();
            services.AddScoped<ISupportMethods, SupportMethods>();
        }
    }
}
