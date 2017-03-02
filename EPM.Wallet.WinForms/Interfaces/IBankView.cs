using System;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface IBankView : ITypedView<BankDto, Guid>
    {
        #region Details
        string BankName { get; set; }
        #endregion //Details
    }

}