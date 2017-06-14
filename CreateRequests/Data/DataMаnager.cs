using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CreateRequests.Interfaces.Data;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;

namespace CreateRequests.Data
{
    public class DataMаnager : IDataMаnager
    {
        private readonly string _apiBankAccounts;
        private readonly string _apiBanks;
        private readonly string _apiCards;
        private readonly string _apiClientAccounts;
        private readonly string _apiClients;
        private readonly string _apiCurrencies;
        private readonly string _apiMessages;
        private readonly string _apiRequests;
        private readonly string _apiStandingOrders;
        private readonly string _apiTransactions;
        private readonly HttpClient _walletHttpClient;

        public DataMаnager()
        {
            #region Endpoints

            var baseApi = ConfigurationManager.AppSettings["BaseApi"];
            var token = ConfigurationManager.AppSettings["ExternalToken"];
            _apiBankAccounts = $"{baseApi}{WalletConstants.ClientAppApi.BankAccounts}/";
            _apiBanks = $"{baseApi}{WalletConstants.ClientAppApi.Banks}/";
            _apiClientAccounts = $"{baseApi}{WalletConstants.ClientAppApi.Accounts}/";
            _apiClients = $"{baseApi}{WalletConstants.ClientAppApi.Clients}/";
            _apiCurrencies = $"{baseApi}{WalletConstants.ClientAppApi.Currencies}/";
            _apiCards = $"{baseApi}{WalletConstants.ClientAppApi.Cards}/";
            _apiRequests = $"{baseApi}{WalletConstants.ClientAppApi.Requests}/";
            _apiMessages = $"{baseApi}{WalletConstants.ClientAppApi.Messages}/";
            _apiTransactions = $"{baseApi}{WalletConstants.ClientAppApi.Transactions}/";
            _apiStandingOrders = $"{baseApi}{WalletConstants.ClientAppApi.StandingOrders}/";

            #endregion

            _walletHttpClient = new HttpClient(new LoggingHandler());
            _walletHttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);
        }

        #region Currencies

        public async Task<IEnumerable<CurrencyDto>> GetCurrencies()
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiCurrencies}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<List<CurrencyDto>>();
                return result;
            }
        }

        #endregion //Currencies

        #region Transactions

        public async Task<TransactionDto> PostTransaction(TransactionDto item)
        {
            using (var response = await _walletHttpClient.PostAsJsonAsync($"{_apiTransactions}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<TransactionDto>();
                return result;
            }
        }

        #endregion //Transactions

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

        #endregion //StandingOrders

        #region ClientAccounts

        public async Task<IEnumerable<AccountDto>> GetClientAccounts()
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiClientAccounts}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<List<AccountDto>>();
                return result.OrderBy(d => d.ClientId);
            }
        }

        public async Task<AccountDto> GetClientAccount(Guid id)
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiClientAccounts}{id}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<AccountDto>();
                return result;
            }
        }

        public async Task<AccountDto> PostClientAccount(AccountDto item)
        {
            using (var response = await _walletHttpClient.PostAsJsonAsync($"{_apiClientAccounts}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<AccountDto>();
                return result;
            }
        }

        public async Task<AccountDto> PutClientAccount(AccountDto item)
        {
            using (var response = await _walletHttpClient.PutAsJsonAsync($"{_apiClientAccounts}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<AccountDto>();
                return result;
            }
        }

        public async Task<bool> DeleteClientAccount(Guid id)
        {
            using (var response = await _walletHttpClient.DeleteAsync($"{_apiClientAccounts}{id}"))
            {
                return response.IsSuccessStatusCode;
            }
        }

        #endregion //ClientAccounts

        #region Cards

        public async Task<IEnumerable<CardDto>> GetCards()
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiCards}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<List<CardDto>>();
                return result.OrderBy(d => d.ClientId).ToList();
            }
        }

        public async Task<CardDto> GetCard(Guid id)
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiCards}{id}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<CardDto>();
                return result;
            }
        }

        public async Task<CardDto> PostCard(CardDto item)
        {
            using (var response = await _walletHttpClient.PostAsJsonAsync($"{_apiCards}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<CardDto>();
                return result;
            }
        }

        public async Task<CardDto> PutCard(CardDto item)
        {
            using (var response = await _walletHttpClient.PutAsJsonAsync($"{_apiCards}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<CardDto>();
                return result;
            }
        }

        public async Task<bool> DeleteCard(Guid id)
        {
            using (var response = await _walletHttpClient.DeleteAsync($"{_apiCards}{id}"))
            {
                return response.IsSuccessStatusCode;
            }
        }

        #endregion //Cards

        #region Banks

        public async Task<IEnumerable<BankDto>> GetBanks()
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiBanks}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<List<BankDto>>();
                return result.OrderBy(d => d.Name).ToList();
            }
        }

        public async Task<BankDto> GetBank(Guid id)
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiBanks}{id}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<BankDto>();
                return result;
            }
        }

        public async Task<BankDto> PostBank(BankDto item)
        {
            using (var response = await _walletHttpClient.PostAsJsonAsync($"{_apiBanks}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<BankDto>();
                return result;
            }
        }

        public async Task<BankDto> PutBank(BankDto item)
        {
            using (var response = await _walletHttpClient.PutAsJsonAsync($"{_apiBanks}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<BankDto>();
                return result;
            }
        }

        public async Task<bool> DeleteBank(Guid id)
        {
            using (var response = await _walletHttpClient.DeleteAsync($"{_apiBanks}{id}"))
            {
                return response.IsSuccessStatusCode;
            }
        }

        #endregion //Banks

        #region BankAccounts

        public async Task<IEnumerable<BankAccountDto>> GetBankAccounts()
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiBankAccounts}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<List<BankAccountDto>>();
                return result.OrderBy(i => i.Name).ThenBy(i => i.CurrencyId).ToList();
            }
        }

        public async Task<BankAccountDto> GetBankAccount(Guid id)
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiBankAccounts}{id}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<BankAccountDto>();
                return result;
            }
        }

        public async Task<BankAccountDto> PostBankAccount(BankAccountDto item)
        {
            using (var response = await _walletHttpClient.PostAsJsonAsync($"{_apiBankAccounts}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<BankAccountDto>();
                return result;
            }
        }

        public async Task<BankAccountDto> PutBankAccount(BankAccountDto item)
        {
            using (var response = await _walletHttpClient.PutAsJsonAsync($"{_apiBankAccounts}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<BankAccountDto>();
                return result;
            }
        }

        public async Task<bool> DeleteBankAccount(Guid id)
        {
            using (var response = await _walletHttpClient.DeleteAsync($"{_apiBankAccounts}{id}"))
            {
                return response.IsSuccessStatusCode;
            }
        }

        #endregion //BankAccounts

        #region Clients

        public async Task<IEnumerable<ClientDto>> GetClients()
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiClients}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<List<ClientDto>>();
                return result;
            }
        }

        public async Task<ClientDto> GetClient(string id)
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiClients}{id}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<ClientDto>();
                return result;
            }
        }

        public async Task<ClientDto> PostClient(ClientDto item)
        {
            using (var response = await _walletHttpClient.PostAsJsonAsync($"{_apiClients}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<ClientDto>();
                return result;
            }
        }

        public async Task<ClientDto> PutClient(ClientDto item)
        {
            using (var response = await _walletHttpClient.PutAsJsonAsync($"{_apiClients}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<ClientDto>();
                return result;
            }
        }

        public async Task<bool> DeleteClientk(string id)
        {
            using (var response = await _walletHttpClient.DeleteAsync($"{_apiClients}{id}"))
            {
                return response.IsSuccessStatusCode;
            }
        }

        #endregion //Clients

        #region Requests

        public async Task<IEnumerable<RequestDto>> GetRequests()
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiRequests}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<List<RequestDto>>();
                return result.OrderBy(d => d.ClientId).ToList();
            }
        }

        public async Task<RequestDto> GetRequest(Guid id)
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiRequests}{id}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<RequestDto>();
                return result;
            }
        }

        public async Task<RequestDto> PostRequest(RequestDto item)
        {
            using (var response = await _walletHttpClient.PostAsJsonAsync($"{_apiRequests}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<RequestDto>();
                return result;
            }
        }

        public async Task<RequestDto> PutRequest(RequestDto item)
        {
            using (var response = await _walletHttpClient.PutAsJsonAsync($"{_apiRequests}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<RequestDto>();
                return result;
            }
        }

        public async Task<bool> DeleteRequest(Guid id)
        {
            using (var response = await _walletHttpClient.DeleteAsync($"{_apiRequests}{id}"))
            {
                return response.IsSuccessStatusCode;
            }
        }

        #endregion

        #region Messages

        public async Task<IEnumerable<MessageDto>> GetMessages()
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiMessages}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<List<MessageDto>>();
                return result.OrderBy(d => d.ClientId).ToList();
            }
        }

        public async Task<MessageDto> GetMessage(Guid id)
        {
            using (var response = await _walletHttpClient.GetAsync($"{_apiMessages}{id}"))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<MessageDto>();
                return result;
            }
        }

        public async Task<MessageDto> PostMessage(MessageDto item)
        {
            using (var response = await _walletHttpClient.PostAsJsonAsync($"{_apiMessages}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<MessageDto>();
                return result;
            }
        }

        public async Task<MessageDto> PutMessage(MessageDto item)
        {
            using (var response = await _walletHttpClient.PutAsJsonAsync($"{_apiMessages}", item))
            {
                if (!response.IsSuccessStatusCode) return null;
                var result = await response.Content.ReadAsAsync<MessageDto>();
                return result;
            }
        }

        public async Task<bool> DeleteMessage(Guid id)
        {
            using (var response = await _walletHttpClient.DeleteAsync($"{_apiMessages}{id}"))
            {
                return response.IsSuccessStatusCode;
            }
        }

        #endregion
    }
}