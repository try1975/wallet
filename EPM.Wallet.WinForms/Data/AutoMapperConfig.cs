using AutoMapper.Configuration;
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

            cfg.CreateMap<TransferOutInfoDto, TransferOutInfoDto>()
                ;
            cfg.CreateMap<TransferOutInfoDto, ITransferOutInfoView>()
               ;
            cfg.CreateMap<ITransferOutInfoView, TransferOutInfoDto>()
                ;
        }
    }
}