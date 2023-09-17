using RestSharp;
using RestSharp.Authenticators;
using System.Text.Json.Serialization;

namespace Orders.Api.Authenticator
{
    public class ImpactAuthenticator : AuthenticatorBase
    {
        private readonly string _baseUrl;
        private readonly string _email;

        public ImpactAuthenticator(String baseUrl, String email)
            : base("")
        {
            _baseUrl = baseUrl;
            _email = email;
        }

        protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
        {
            Token = string.IsNullOrEmpty(Token) ? await GetToken() : Token;
            return new HeaderParameter(KnownHeaders.Authorization, $"Bearer {Token}");
        }

        async Task<string> GetToken()
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest("/Login");
            var obj = new { email = "eltim.alves@gmail.com" };

            request.AddBody(obj, ContentType.Json);

            var response = await client.PostAsync<TokenResponse>(request);

            Console.WriteLine(response.Token);

            return response.Token;

        }

        record TokenResponse
        {
            [JsonPropertyName("token")]
            public string Token { get; init; }
        }
    }
}
