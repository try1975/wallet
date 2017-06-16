using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;

namespace CreateRequests.Data
{
    public class DataMаnager
    {
        private readonly string _apiStandingOrders;
        private readonly HttpClient _walletHttpClient;

        public DataMаnager()
        {
            #region Endpoints

            var baseApi = ConfigurationManager.AppSettings["BaseApi"];
            var token = ConfigurationManager.AppSettings["ExternalToken"];
            _apiStandingOrders = $"{baseApi}{WalletConstants.ClientAppApi.StandingOrders}/";

            #endregion

            _walletHttpClient = new HttpClient(new LoggingHandler());
            _walletHttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);
        }

        #region StandingOrders

        public async Task<IEnumerable<StandingOrderDto>> GetStandingOrders()
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiStandingOrders}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<List<StandingOrderDto>>();
                return result;
            }
        }

        public async Task<Guid> CreateRequest(Guid standingOrderId)
        {
            using (
                var response =
                    await
                        _walletHttpClient.PostAsync($"{_apiStandingOrders}/{nameof(CreateRequest)}/{standingOrderId}",
                            null))
            {
                if (!response.IsSuccessStatusCode) return Guid.Empty;
                var result = await response.Content.ReadAsAsync<Guid>();
                return result;
            }
        }

        #endregion //StandingOrders
    }
}