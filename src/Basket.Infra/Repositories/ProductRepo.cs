using Basket.Api.Authenticator;
using Basket.Domain.Entities.Products;
using Basket.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace Basket.Infra.Repositories
{
    public class ProductRepo : IProductRepo, IDisposable
    {
        readonly IConfiguration _config;
        readonly RestClient _client;
        readonly ILogger<ProductRepo> _logger;
        
        public ProductRepo(IConfiguration config, ILogger<ProductRepo> logger)
        {
            _config = config;
            _logger = logger;

            var options = new RestClientOptions(_config["Settings:baseUrl"])
            {
                Authenticator = new EndPointsAuthenticator(_config["Settings:baseUrl"], _config["Settings:email"])
            };
            _client = new RestClient(options, null, null, true);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            IEnumerable<Product> response = new List<Product>();

            try
            {
                response = await _client.GetJsonAsync<List<Product>>("/GetAllProducts") ?? new List<Product>() { };
                _logger.LogInformation($"{DateTime.UtcNow}: GetProductsTopHundred called with result of {response!.Count()} products.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{DateTime.UtcNow}: Error on ProductClient.GetProductsTopRanked ");
            }

            return await Task.FromResult(response);

        }

        public void Dispose()
        {
            _client?.Dispose();
            GC.SuppressFinalize(this);
            _logger.LogInformation($"{DateTime.UtcNow}: ProductClient disposed.");
        }
    }
}
