using System;
using EPM.Wallet.Common.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public class BankPresenter : TypedPresenter<BankDto, Guid>
    {
        public BankPresenter(IBankView view, IBankDataMаnager typedDataMаnager, IDataMаnager dataMаnager) : base(view, typedDataMаnager, dataMаnager)
        {
        }
    }
}