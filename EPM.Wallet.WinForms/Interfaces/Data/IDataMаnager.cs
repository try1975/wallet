using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface IDataMаnager
    {
        #region Currencies

        Task<IEnumerable<CurrencyDto>> GetCurrencies();

        #endregion //Currencies

        #region ClientAccountStatuses
        Task<IEnumerable<ClientAccountStatusDto>> GetClientAccountStatuses();
        #endregion //ClientAccountStatuses


        #region Banks

        Task<IEnumerable<BankDto>> GetBanks();
        Task<BankDto> GetBank(Guid id);
        //Task<Bank> GetBank(Uri uri);
        Task<BankDto> PostBank(BankDto item);
        Task<BankDto> PutBank(BankDto item);
        Task<bool> DeleteBank(Guid id);

        #endregion //Banks

        #region BankAccounts

        Task<IEnumerable<BankAccountDto>> GetBankAccounts();
        Task<BankAccountDto> GetBankAccount(Guid id);
        Task<BankAccountDto> PostBankAccount(BankAccountDto item);
        Task<BankAccountDto> PutBankAccount(BankAccountDto item);
        Task<bool> DeleteBankAccount(Guid id);

        #endregion //BankAccounts

        #region Clients

        Task<IEnumerable<ClientDto>> GetClients();
        Task<ClientDto> GetClient(string id);
        Task<ClientDto> PostClient(ClientDto item);
        Task<ClientDto> PutClient(ClientDto item);
        Task<bool> DeleteClientk(string id);

        #endregion //Clients

        #region ClientAccounts

        Task<IEnumerable<AccountDto>> GetClientAccounts();
        Task<AccountDto> GetClientAccount(Guid id);
        Task<AccountDto> PostClientAccount(AccountDto item);
        Task<AccountDto> PutClientAccount(AccountDto item);
        Task<bool> DeleteClientAccount(Guid id);

        #endregion //ClientAccounts

        #region Cards

        Task<IEnumerable<CardDto>> GetCards();
        Task<CardDto> GetCard(Guid id);
        Task<CardDto> PostCard(CardDto item);
        Task<CardDto> PutCard(CardDto item);
        Task<bool> DeleteCard(Guid id);

        #endregion //Cards

      
    }
}