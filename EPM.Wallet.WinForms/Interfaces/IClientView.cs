using EPM.Wallet.Common.Model;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface IClientView : ITypedView<ClientDto, string>
    {
        string ClientName { get; set; }
    }
}