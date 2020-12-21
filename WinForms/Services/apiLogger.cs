using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace WinForms.Services
{
    class ApiLogger : WebRequestHandler
    {
        // Let's log all of our requests!

        public ApiLogger()
        {
            // Allow any cert, valid or invalid
            ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);
            Console.WriteLine((await response.Content.ReadAsStringAsync()).Trim());
            return response;
        }
    }
}
