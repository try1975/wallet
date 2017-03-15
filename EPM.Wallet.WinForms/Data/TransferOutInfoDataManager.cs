using System;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    public class TransferOutInfoDataManager : TypedDataMаnager<TransferOutInfoDto, Guid>, ITransferOutInfoDataManager
    {
        public TransferOutInfoDataManager()
            : base(WalletConstants.ClientAppApi.ApiSegmentName + WalletConstants.AccountByClientRoutes.TransferOut)
        {
        }
    }
}