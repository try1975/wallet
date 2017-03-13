using System;

namespace EPM.Wallet.Internal.Model
{
    public class AccountStatementDataDto
    {
        public string AccountName { get; set; }

        public DateTimeOffset ValueDate { get; set; }

        public string Period { get; set; }

        public decimal PreviousBalance { get; set; }

        public decimal Credits { get; set; }

        public decimal Debits { get; set; }

        public decimal NewBalance { get; set; }

        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public string LoadedFrom { get; set; }

    }
}