using System;
using System.Collections.Generic;
using System.Linq;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public sealed class ClientAccountPresenter : TypedPresenter<AccountDto, Guid>
    {
        public ClientAccountPresenter(IClientAccountView view, IClientAccountDataManager typedDataMаnager, IDataMаnager dataMаnager) : base(view, typedDataMаnager, dataMаnager)
        {
            LoadLists();
        }
        public override async void LoadLists()
        {
            var clientDtos = await DataMаnager.GetClients();
            if (clientDtos != null)
            {
                var banks = clientDtos.ToList();
                ((IClientAccountView)View).ClientList =
                    banks.Select(c => new KeyValuePair<string, string>(c.Id, $"{c.Name} [{c.Id}]"))
                        .OrderBy(kv => kv.Key)
                        .ToList();
            }
            else
            {
                ((IClientAccountView)View).ClientList = new List<KeyValuePair<string, string>>();
            }

            var currencyDtos = await DataMаnager.GetCurrencies();
            if (currencyDtos != null)
            {
                var currencies = currencyDtos.ToList();
                ((IClientAccountView)View).CurrencyList =
                    currencies.Select(c => new KeyValuePair<string, string>(c.Id, c.Id))
                        .OrderBy(kv => kv.Value)
                        .ToList();
            }
            else
            {
                ((IClientAccountView)View).CurrencyList = new List<KeyValuePair<string, string>>();
            }

            var bankAccountDtos = await DataMаnager.GetBankAccounts();
            if (bankAccountDtos != null)
            {
                var bankaccounts = bankAccountDtos.ToList();
                ((IClientAccountView)View).BankAccounList =
                    bankaccounts.Select(c => new KeyValuePair<Guid, string>(c.Id, $"{c.Name} [{c.CurrencyId}]"))
                        .OrderBy(kv => kv.Value)
                        .ToList();
            }
            else
            {
                ((IClientAccountView)View).BankAccounList = new List<KeyValuePair<Guid, string>>();
            }

            var clientAccountStatusDtos = await DataMаnager.GetClientAccountStatuses();
            if (clientAccountStatusDtos != null)
            {
                var clientAccountStatuses = clientAccountStatusDtos.ToList();
                ((IClientAccountView)View).ClientAccountStatusList =
                   clientAccountStatuses.Select(c => new KeyValuePair<string, string>(c.Id, c.Id))
                       .OrderBy(kv => kv.Value)
                       .ToList();
            }
            else
            {
                ((IClientAccountView)View).ClientAccountStatusList = new List<KeyValuePair<string, string>>();
            }
        }
    }
}
