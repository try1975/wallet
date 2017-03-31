using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace WalletWebApi.Logging
{
    public class LogHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // log request body
            var requestBody = await request.Content.ReadAsStringAsync();
            Trace.WriteLine(requestBody);

            // let other handlers process the request
            var result = await base.SendAsync(request, cancellationToken);

            if (result.Content == null) return result;
            // once response body is ready, log it
            var responseBody = await result.Content.ReadAsStringAsync();
            Trace.WriteLine(responseBody);

            return result;
        }
    }
}