using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public interface IBankByIdQueryProcessor
    {
        BankEntity GetBank(int id);
    }
}