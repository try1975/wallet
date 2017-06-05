using System;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public class RequestPresenter : TypedPresenter<RequestInfoDto, Guid>
    {
        public RequestPresenter(IRequestView view, IRequestDataManager typedDataMаnager,
            IDataMаnager dataMаnager) : base(view, typedDataMаnager, dataMаnager)
        {
            //LoadLists();
        }

        //private async void LoadLists()
        //{
        //    var currencyDtos = await DataMаnager.GetCurrencies();
        //    if (currencyDtos != null)
        //    {
        //        var currencies = currencyDtos.ToList();
        //        ((IRequestView) View).CurrencyList =
        //            currencies.Select(c => new KeyValuePair<string, string>(c.Id, c.Id))
        //                .ToList();
        //    }
        //    else
        //    {
        //        ((IRequestView) View).CurrencyList = new List<KeyValuePair<string, string>>();
        //    }

        //    var names = Enum.GetNames(typeof(RequestStatus));
        //    //var list = (from RequestStatus status in Enum.GetValues(typeof(RequestStatus)) select new KeyValuePair<RequestStatus, string>(status, names[(int) status])).ToList();

        //    var requestStatusesList = new List<KeyValuePair<RequestStatus, string>>
        //    {
        //        new KeyValuePair<RequestStatus, string>(RequestStatuses.GetPendingRequestStatus(), names[(int) RequestStatuses.GetPendingRequestStatus()]),
        //        new KeyValuePair<RequestStatus, string>(RequestStatuses.GetProcessedRequestStatus(), names[(int) RequestStatuses.GetProcessedRequestStatus()]),
        //        new KeyValuePair<RequestStatus, string>(RequestStatuses.GetRejectedRequestStatus(), names[(int) RequestStatuses.GetRejectedRequestStatus()])
        //    };

        //    ((IRequestView)View).RequestStatusList = requestStatusesList;
        //}
    }
}