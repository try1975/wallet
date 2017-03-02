using System;
using System.Collections.Generic;
using System.Linq;
using EPM.Wallet.Common.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public sealed class CardPresenter : TypedPresenter<CardDto, Guid>
    {
        public CardPresenter(ICardView view, ICardDataMаnager typedDataMаnager, IDataMаnager dataMаnager)
            : base(view, typedDataMаnager, dataMаnager)
        {
            LoadLists();
        }
        public override async void LoadLists()
        {
            var clientDtos = await DataMаnager.GetClients();
            if (clientDtos != null)
            {
                var banks = clientDtos.ToList();
                ((ICardView)View).ClientList =
                    banks.Select(c => new KeyValuePair<string, string>(c.Id, $"{c.Name} [{c.Id}]"))
                        .OrderBy(kv => kv.Key)
                        .ToList();
            }
            else
            {
                ((ICardView)View).ClientList = new List<KeyValuePair<string, string>>();
            }

            var currencyDtos = await DataMаnager.GetCurrencies();
            if (currencyDtos != null)
            {
                var currencies = currencyDtos.ToList();
                ((ICardView)View).CurrencyList =
                    currencies.Select(c => new KeyValuePair<string, string>(c.Id, c.Id))
                        .OrderBy(kv => kv.Value)
                        .ToList();
            }
            else
            {
                ((ICardView)View).CurrencyList = new List<KeyValuePair<string, string>>();
            }
        }
    }
}