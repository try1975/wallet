using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using EPM.Wallet.Internal;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    public abstract class TypedDataM�nager<T, TK> : ITypedDataM�nager<T, TK> where T : class, IDto<TK>
    {
        private readonly string _endPoint;
        private readonly HttpClient _walletHttpClient;

        protected TypedDataM�nager(string endPoint)
        {
            var baseApi = ConfigurationManager.AppSettings["BaseApi"];
            var token = ConfigurationManager.AppSettings["ExternalToken"];
            _endPoint = $"{baseApi}{endPoint}/";

            _walletHttpClient = new HttpClient(new LoggingHandler());
            _walletHttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);
        }

        public async Task<IEnumerable<T>> GetItems()
        {
            using (var response = await _walletHttpClient.GetAsync($"{_endPoint}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<List<T>>();
                return result;
            }
        }

        public async Task<T> GetItem(TK id)
        {
            using (var response = await _walletHttpClient.GetAsync($"{_endPoint}{id}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<T>();
                return result;
            }
        }

        public async Task<T> PostItem(T item)
        {
            using (var response = await _walletHttpClient.PostAsJsonAsync($"{_endPoint}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<T>();
                return result;
            }
        }

        public async Task<T> PutItem(T item)
        {
            using (var response = await _walletHttpClient.PutAsJsonAsync($"{_endPoint}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<T>();
                return result;
            }
        }

        public async Task<bool> DeleteItem(TK id)
        {
            using (var response = await _walletHttpClient.DeleteAsync($"{_endPoint}{id}"))
            {
                return response.IsSuccessStatusCode;
            }
        }
    }
}