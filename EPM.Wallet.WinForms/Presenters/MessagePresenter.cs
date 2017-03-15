using System;
using System.Collections.Generic;
using System.Linq;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public class MessagePresenter : TypedPresenter<MessageDto, Guid>
    {
        public MessagePresenter(IMessageView view, IMessageDataManager typedDataManager
            , IDataMаnager dataMаnager) : base(view, typedDataManager, dataMаnager)
        {
            LoadLists();
        }

        private async void LoadLists()
        {
            var clientDtos = await DataMаnager.GetClients();
            if (clientDtos != null)
            {
                var currencies = clientDtos.ToList();
                ((IMessageView) View).ClientList =
                    currencies.Select(c => new KeyValuePair<string, string>(c.Id, c.Id))
                        .OrderBy(kv => kv.Value)
                        .ToList();
            }
            else
            {
                ((IMessageView) View).ClientList = new List<KeyValuePair<string, string>>();
            }
        }
    }
}