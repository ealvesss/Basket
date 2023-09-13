using basket_api.Service;
using basket_api.Service.Orders.Interfaces;
using basket_api.Service.Products.Interfaces;

namespace basket_api.Extensions
{
    public static class DependencyInjectionExt
    {

        public static void InjectDependencies(this IServiceCollection services) {
            services.AddScoped<IOrder, Order>();
            services.AddScoped<IProduct, Product>();
        }
    }
}
