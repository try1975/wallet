using System;
using System.Collections.Generic;
using System.Linq;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public class StatementPresenter : TypedPresenter<StatementDto, Guid>
    {
        public StatementPresenter(IStatementView view, IStatementDataManager typedDataMаnager, IDataMаnager dataMаnager) : base(view, typedDataMаnager, dataMаnager)
        {
            LoadLists();
        }

        private async void LoadLists()
        {
            var accountDtos = await DataMаnager.GetClientAccounts();
            if (accountDtos != null)
            {
                var currencies = accountDtos.ToList();
                ((IStatementView)View).AccountList =
                    currencies.Select(c => new KeyValuePair<Guid, string>(c.Id, $"{c.Name} [{c.ClientId} {c.CurrencyId}]"))
                        .OrderBy(kv => kv.Value)
                        .ToList();
            }
            else
            {
                ((IStatementView)View).AccountList = new List<KeyValuePair<Guid, string>>();
            }
        }
    }
}