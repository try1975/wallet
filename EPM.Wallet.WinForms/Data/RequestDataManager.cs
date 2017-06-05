using System;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    internal class RequestDataManager : TypedDataMаnager<RequestInfoDto, Guid>, IRequestDataManager
    {
        public RequestDataManager() : base(WalletConstants.ClientAppApi.Requests)
        {
        }
    }
}