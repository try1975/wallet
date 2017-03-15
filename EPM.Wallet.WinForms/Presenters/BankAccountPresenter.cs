using System;
using System.Collections.Generic;
using System.Linq;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public class BankAccountPresenter : TypedPresenter<BankAccountDto, Guid>
    {
        public BankAccountPresenter(IBankAccountView view, IBankAccountDataManager typedDataMаnager,
            IDataMаnager dataMаnager) : base(view, typedDataMаnager, dataMаnager)
        {
            LoadLists();
        }

        private async void LoadLists()
        {
            var currencyDtos = await DataMаnager.GetCurrencies();
            if (currencyDtos != null)
            {
                var currencies = currencyDtos.ToList();
                ((IBankAccountView) View).CurrencyList =
                    currencies.Select(c => new KeyValuePair<string, string>(c.Id, c.Id))
                        .OrderBy(kv => kv.Value)
                        .ToList();
            }
            else
            {
                ((IBankAccountView) View).CurrencyList = new List<KeyValuePair<string, string>>();
            }

            var bankDtos = await DataMаnager.GetBanks();
            if (bankDtos != null)
            {
                var banks = bankDtos.ToList();
                ((IBankAccountView) View).BankList =
                    banks.Select(c => new KeyValuePair<Guid, string>(c.Id, c.Name))
                        .OrderBy(kv => kv.Value)
                        .ToList();
            }
            else
            {
                ((IBankAccountView) View).BankList = new List<KeyValuePair<Guid, string>>();
            }
        }
    }
}