using System;
using System.Collections.Generic;
using System.Linq;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public sealed class ClientAccountPresenter : TypedPresenter<AccountDto, Guid>
    {
        public ClientAccountPresenter(IClientAccountView view, IClientAccountDataManager typedDataMаnager,
            IDataMаnager dataMаnager) : base(view, typedDataMаnager, dataMаnager)
        {
            LoadLists();
        }

        private async void LoadLists()
        {
            var clientDtos = await DataMаnager.GetClients();
            if (clientDtos != null)
            {
                var banks = clientDtos.ToList();
                ((IClientAccountView) View).ClientList =
                    banks.Select(c => new KeyValuePair<string, string>(c.Id, $"{c.Name} [{c.Id}]"))
                        .OrderBy(kv => kv.Key)
                        .ToList();
            }
            else
            {
                ((IClientAccountView) View).ClientList = new List<KeyValuePair<string, string>>();
            }

            var currencyDtos = await DataMаnager.GetCurrencies();
            if (currencyDtos != null)
            {
                var currencies = currencyDtos.ToList();
                ((IClientAccountView) View).CurrencyList =
                    currencies.Select(c => new KeyValuePair<string, string>(c.Id, c.Id))
                        .ToList();
            }
            else
            {
                ((IClientAccountView) View).CurrencyList = new List<KeyValuePair<string, string>>();
            }

            var bankAccountDtos = await DataMаnager.GetBankAccounts();
            if (bankAccountDtos != null)
            {
                var bankaccounts = bankAccountDtos.ToList();
                ((IClientAccountView) View).BankAccounList =
                    bankaccounts.Select(c => new KeyValuePair<Guid, string>(c.Id, $"{c.Name} [{c.CurrencyId}]"))
                        .OrderBy(kv => kv.Value)
                        .ToList();
            }
            else
            {
                ((IClientAccountView) View).BankAccounList = new List<KeyValuePair<Guid, string>>();
            }


            var names = Enum.GetNames(typeof(ClientAccountStatus));
            var clientAccountStatusList = new List<KeyValuePair<ClientAccountStatus, string>>
            {
                new KeyValuePair<ClientAccountStatus, string>(ClientAccountStatus.Active, names[(int) ClientAccountStatus.Active]),
                new KeyValuePair<ClientAccountStatus, string>(ClientAccountStatus.Inactive, names[(int) ClientAccountStatus.Inactive]),
            };

            ((IClientAccountView)View).ClientAccountStatusList = clientAccountStatusList;
        }
    }
}