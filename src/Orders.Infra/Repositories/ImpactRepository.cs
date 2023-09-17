using Microsoft.Extensions.Configuration;
using Orders.Api.Authenticator;
using Orders.Domain.Entities.Products;
using Orders.Infra.Interfaces;

namespace Orders.Infra.Repositories
{
    public class ImpactRepository : IImpactRepository
    {
        private readonly IConfiguration _config;

        public ImpactRepository(IConfiguration config)
        {
            _config = config;
        }


        public async Task<List<Product>> GetAllProducts()
        {

            var auth = new ImpactAuthenticator(_config["Settings:baseUrl"], "eltim.alves@gmail.com");

            return null;
        }


    }
}
