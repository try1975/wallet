using System;
using System.Collections.Generic;
using System.Linq;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public class TransferOutInfoPresenter : TypedPresenter<TransferOutInfoDto, Guid>
    {
        public TransferOutInfoPresenter(ITransferOutInfoView view, ITransferOutInfoDataManager typedDataMаnager,
            IDataMаnager dataMаnager) : base(view, typedDataMаnager, dataMаnager)
        {
            LoadLists();
        }

        public sealed override void LoadLists()
        {
            var names = Enum.GetNames(typeof(RequestStatus));
            var list = (from RequestStatus status in Enum.GetValues(typeof(RequestStatus)) select new KeyValuePair<RequestStatus, string>(status, names[(int) status])).ToList();
            ((ITransferOutInfoView)View).RequestStatusList = list;
        }
    }
}