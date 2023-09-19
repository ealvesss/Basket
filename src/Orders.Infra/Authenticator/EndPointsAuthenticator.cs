using RestSharp;
using RestSharp.Authenticators;
using System.Text.Json.Serialization;

namespace Orders.Api.Authenticator
{
    public class EndPointsAuthenticator : AuthenticatorBase
    {
        readonly string _baseUrl;
        readonly string _email;

        public EndPointsAuthenticator(String baseUrl, String email)
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
            var client = new RestClient(new Uri(_baseUrl), null, null, null, true);
            var request = new RestRequest("/Login");

            try
            {
                request.AddJsonBody($"{{ \"email\" : \"{_email}\" }}");
                var response = await client.PostAsync<TokenResponse>(request);
                return response!.Token;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        record TokenResponse
        {
            [JsonPropertyName("token")]
            public string? Token { get; init; }
        }
    }
}
