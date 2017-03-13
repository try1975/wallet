using System;

namespace EPM.Wallet.Internal.Model
{
    public class StatementDto : IDto<Guid>
    {
        public Guid Id { get; set; }
    }
}