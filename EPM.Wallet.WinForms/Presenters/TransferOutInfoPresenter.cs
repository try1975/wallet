using System;
using System.Collections.Generic;
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

        private void LoadLists()
        {
            var names = Enum.GetNames(typeof(RequestStatus));
            //var list = (from RequestStatus status in Enum.GetValues(typeof(RequestStatus)) select new KeyValuePair<RequestStatus, string>(status, names[(int) status])).ToList();

            var requestStatusesList = new List<KeyValuePair<RequestStatus, string>>
            {
                new KeyValuePair<RequestStatus, string>(RequestStatuses.GetPendingRequestStatus(), names[(int) RequestStatuses.GetPendingRequestStatus()]),
                new KeyValuePair<RequestStatus, string>(RequestStatuses.GetProcessedRequestStatus(), names[(int) RequestStatuses.GetProcessedRequestStatus()]),
                new KeyValuePair<RequestStatus, string>(RequestStatuses.GetRejectedRequestStatus(), names[(int) RequestStatuses.GetRejectedRequestStatus()])
            };

            ((ITransferOutInfoView) View).RequestStatusList = requestStatusesList;
        }
    }
}