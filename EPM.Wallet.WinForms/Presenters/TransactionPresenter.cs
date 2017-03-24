using System;
using System.Collections.Generic;
using System.Linq;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    class TransactionPresenter : TypedPresenter<TransactionDto, Guid>
    {
        public TransactionPresenter(ITransactionView view, ITransactionDataManager typedDataMаnager, IDataMаnager dataMаnager) : base(view, typedDataMаnager, dataMаnager)
        {
            LoadLists();
        }

        private async void LoadLists()
        {
            var accountDtos = await DataMаnager.GetClientAccounts();
            if (accountDtos != null)
            {
                var currencies = accountDtos.ToList();
                ((ITransactionView)View).AccountList =
                    currencies.Select(c => new KeyValuePair<Guid, string>(c.Id, $"{c.Name} [{c.ClientId} {c.CurrencyId}]"))
                        .OrderBy(kv => kv.Value)
                        .ToList();
            }
            else
            {
                ((ITransactionView)View).AccountList = new List<KeyValuePair<Guid, string>>();
            }

            var currencyDtos = await DataMаnager.GetCurrencies();
            if (currencyDtos != null)
            {
                var currencies = currencyDtos.ToList();
                ((ITransactionView)View).CurrencyList =
                    currencies.Select(c => new KeyValuePair<string, string>(c.Id, c.Id))
                        .ToList();
            }
            else
            {
                ((ITransactionView)View).CurrencyList = new List<KeyValuePair<string, string>>();
            }
        }
    }
}
