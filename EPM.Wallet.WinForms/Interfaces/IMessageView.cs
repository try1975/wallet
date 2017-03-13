using System;
using System.Collections.Generic;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface IMessageView : ITypedView<MessageDto, Guid>
    {
        #region Details

        string Subject { get; set; }
        string Body { get; set; }
        string ClientId { get; set; }
        DateTime Date { get; set; }
        DateTime? ReadDate { get; set; }
        bool IsOutgoing { get; set; }


        #endregion // Details

        #region DetailsLists

        List<KeyValuePair<string, string>> ClientList { set; }
        #endregion //DetailsLists

    }


}