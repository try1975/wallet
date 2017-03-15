using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public class ClientPresenter : TypedPresenter<ClientDto, string>
    {
        public ClientPresenter(IClientView view, IClientDataManager typedDataMаnager, IDataMаnager dataMаnager)
            : base(view, typedDataMаnager, dataMаnager)
        {
        }
    }
}