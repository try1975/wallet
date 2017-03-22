using System;
using System.Collections.Generic;
using System.Linq;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public class RequestPresenter : TypedPresenter<RequestDto, Guid>
    {
        public RequestPresenter(IRequestView view, IRequestDataManager typedDataMаnager,
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
                ((IRequestView) View).CurrencyList =
                    currencies.Select(c => new KeyValuePair<string, string>(c.Id, c.Id))
                        .ToList();
            }
            else
            {
                ((IRequestView) View).CurrencyList = new List<KeyValuePair<string, string>>();
            }
        }
    }
}