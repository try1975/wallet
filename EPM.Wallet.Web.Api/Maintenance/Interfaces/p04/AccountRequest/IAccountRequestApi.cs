﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public interface IAccountRequestApi : ITypedApi<AccountRequestDto, Guid>
    {
        IEnumerable<AccountRequestDto> RequestsByClient(string clientId);

        bool CreateAccountNewRequest(string clientId, AccountNewRequestDto dto);
        Task<bool> CreateAccountRefillRequest(string clientId, Guid accountId, RefillRequestDto dto);
        bool CreateAccountTransferToCardRequest(string clientId, Guid accountId, TransferToCardRequestDto dto);
        bool CreateAccountTransferOutRequest(string clientId, Guid accountId, TransferOutRequestDto dto);
    }
}