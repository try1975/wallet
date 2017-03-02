using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface IClientView : ITypedView<ClientDto, string>
    {
        string ClientName { get; set; }
    }
}