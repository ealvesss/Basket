using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Orders.Api.Authenticator;
using Orders.Domain.Entities.Products;
using Orders.Domain.Interfaces;
using RestSharp;

namespace Orders.Infra.Repositories
{
    public class ProductClient : IProductClient, IDisposable
    {
        readonly IConfiguration _config;
        readonly RestClient _client;
        readonly ILogger<ProductClient> _logger;

        public ProductClient(IConfiguration config, ILogger<ProductClient> logger)
        {
            _config = config;
            _logger = logger;

            var options = new RestClientOptions(_config["Settings:baseUrl"])
            {
                Authenticator = new EndPointsAuthenticator(_config["Settings:baseUrl"], _config["Settings:email"])
            };
            _client = new RestClient(options, null, null, true);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            List<Product>? response = null;

            try
            {
                response = await _client.GetJsonAsync<List<Product>>("/GetAllProducts");
                _logger.LogInformation($"{DateTime.UtcNow}: GetAllProducts called with result of {response!.Count()} products.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{DateTime.UtcNow}: Error on ProductClient.GetAllProducts");
            }

            return await Task.FromResult(response == null ? new List<Product>() : response.OrderBy(x => x.Stars).OrderBy(order => order.Price).Take(100));
        }

        public void Dispose()
        {
            _client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
