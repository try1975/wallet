using System;

namespace WalletWebApi.Model
{
    public class StatementDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid? AccountId { get; set; }
        public byte[] Content { get; set; }
        public string LoadedFrom { get; set; }
    }
}