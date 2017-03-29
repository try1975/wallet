using System;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    class StatementDataManager : TypedDataMаnager<StatementDto, Guid>, IStatementDataManager
    {
        public StatementDataManager() : base(WalletConstants.ClientAppApi.Statements)
        {
        }
    }
}
