using System;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    class StandingOrderDataManager : TypedDataMаnager<StandingOrderDto, Guid>, IStandingOrderDataManager
    {
        public StandingOrderDataManager() : base(WalletConstants.ClientAppApi.StandingOrders)
        {
        }
    }
}
