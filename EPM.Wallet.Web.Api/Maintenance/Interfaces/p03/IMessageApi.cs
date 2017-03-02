﻿using System;
using System.Collections.Generic;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{

    public interface IMessageApi : ITypedApi<MessageDto, Guid> {
        IEnumerable<MessageDto> GetMessagesByClient(string clientId);
        IEnumerable<MessageDto> GetOutgoingMessagesByClient(string clientId);
        IEnumerable<MessageDto> GetIncomingMessagesByClient(string clientId, DateTime fromDate);
        MessageDto GetMessageByClient(string clientId, Guid id);
        MessageDto PostMessageByClient(string clientId, MessageDto dto);

        int CountUnreadMessagesByClient(string clientId);
        MessageDto MakeMessageReaded(string clientId, Guid id);
        bool MakeMessageInvisible(Guid id);
    }
}