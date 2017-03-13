using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface IClientView : ITypedView<ClientDto, string>
    {
        #region Details

        string ClientName { get; set; }

        #endregion //Details
    }
}