
using MultiShop.WebUI.Services.Interfaces;
using System.Net;
using System.Net.Http.Headers;

namespace MultiShop.WebUI.Handlers
{
    public class ClientCredentialTokenHandler:DelegatingHandler
    {
        private readonly IClientCredentialTokenService _clientCredentialTokenService;
<<<<<<< HEAD
=======

>>>>>>> 6301d81a493aa5cca2ac1f6b70766572a900c91d
        public ClientCredentialTokenHandler(IClientCredentialTokenService clientCredentialTokenService)
        {
            _clientCredentialTokenService = clientCredentialTokenService;
        }
<<<<<<< HEAD
=======

>>>>>>> 6301d81a493aa5cca2ac1f6b70766572a900c91d
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await _clientCredentialTokenService.GetToken());
            var response = await base.SendAsync(request, cancellationToken);
<<<<<<< HEAD
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                //hata mesajı
=======

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                // hata mesajı
>>>>>>> 6301d81a493aa5cca2ac1f6b70766572a900c91d
            }
            return response;
        }
    }
}
