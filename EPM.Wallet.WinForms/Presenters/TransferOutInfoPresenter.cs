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
                new KeyValuePair<RequestStatus, string>(RequestStatus.New, names[(int) RequestStatus.New]),
                new KeyValuePair<RequestStatus, string>(RequestStatus.Pending, names[(int) RequestStatus.Pending]),
                new KeyValuePair<RequestStatus, string>(RequestStatus.Processed, names[(int) RequestStatus.Processed]),
                new KeyValuePair<RequestStatus, string>(RequestStatus.Rejected, names[(int) RequestStatus.Rejected])
            };

            ((ITransferOutInfoView) View).RequestStatusList = requestStatusesList;
        }
    }
}