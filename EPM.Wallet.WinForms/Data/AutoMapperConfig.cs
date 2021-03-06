﻿using AutoMapper.Configuration;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings(MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<BankDto, BankDto>()
                ;
            cfg.CreateMap<BankDto, IBankView>()
                .ForMember(dest => dest.BankName, opt => opt.MapFrom(src => src.Name))
                ;
            cfg.CreateMap<IBankView, BankDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.BankName))
                ;

            cfg.CreateMap<BankAccountDto, BankAccountDto>()
                ;
            cfg.CreateMap<BankAccountDto, IBankAccountView>()
                .ForMember(dest => dest.BankAccountName, opt => opt.MapFrom(src => src.Name))
                ;
            cfg.CreateMap<IBankAccountView, BankAccountDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.BankAccountName))
                ;

            cfg.CreateMap<ClientDto, ClientDto>()
                ;
            cfg.CreateMap<ClientDto, IClientView>()
                .ForMember(dest => dest.ClientName, opt => opt.MapFrom(src => src.Name))
                ;
            cfg.CreateMap<IClientView, ClientDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ClientName))
                ;

            cfg.CreateMap<AccountDto, AccountDto>()
                ;
            cfg.CreateMap<AccountDto, IClientAccountView>()
                .ForMember(dest => dest.ClientAccountName, opt => opt.MapFrom(src => src.Name))
                ;
            cfg.CreateMap<IClientAccountView, AccountDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ClientAccountName))
                ;

            cfg.CreateMap<CardDto, CardDto>()
                ;
            cfg.CreateMap<CardDto, ICardView>()
                ;
            cfg.CreateMap<ICardView, CardDto>()
                ;

            cfg.CreateMap<MessageDto, MessageDto>()
                ;
            cfg.CreateMap<MessageDto, IMessageView>()
                ;
            cfg.CreateMap<IMessageView, MessageDto>()
                ;

            cfg.CreateMap<TransferOutInfoDto, TransferOutInfoDto>()
                ;
            cfg.CreateMap<TransferOutInfoDto, ITransferOutInfoView>()
                ;
            cfg.CreateMap<ITransferOutInfoView, TransferOutInfoDto>()
                ;

            cfg.CreateMap<TransactionDto, TransactionDto>()
                ;
            cfg.CreateMap<TransactionDto, ITransactionView>()
                ;
            cfg.CreateMap<ITransactionView, TransactionDto>()
                ;

            cfg.CreateMap<StatementDto, StatementDto>()
                ;
            cfg.CreateMap<StatementDto, IStatementView>()
                ;
            cfg.CreateMap<IStatementView, StatementDto>()
                ;

            cfg.CreateMap<RequestDto, RequestDto>()
                ;
            cfg.CreateMap<RequestDto, IRequestView>()
                ;
            cfg.CreateMap<IRequestView, RequestDto>()
                ;

            cfg.CreateMap<RequestInfoDto, RequestInfoDto>()
                ;
            cfg.CreateMap<RequestInfoDto, IRequestView>()
                ;
            cfg.CreateMap<IRequestView, RequestInfoDto>()
                ;

            cfg.CreateMap<StandingOrderDto, StandingOrderDto>()
                ;
            cfg.CreateMap<StandingOrderDto, IStandingOrderView>()
                ;
            cfg.CreateMap<IStandingOrderView, StandingOrderDto>()
                ;

            cfg.CreateMap<DirectDebitDto, DirectDebitDto>()
                ;
            cfg.CreateMap<DirectDebitDto, IDirectDebitView>()
                ;
            cfg.CreateMap<IDirectDebitView, DirectDebitDto>()
                ;
        }
    }
}