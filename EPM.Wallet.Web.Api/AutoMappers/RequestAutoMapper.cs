using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using WalletWebApi.Model;

namespace WalletWebApi.AutoMappers
{
    public static class RequestAutoMapper
    {
        public static void Configure(MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<RequestEntity, RequestDto>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.RequestType))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.RequestStatus))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.CreatedAt))
                .Include<CardRequestEntity, CardRequestDto>()
                .Include<AccountRequestEntity, AccountRequestDto>()
                ;
            cfg.CreateMap<RequestDto, RequestEntity>()
                 .ForMember(dest => dest.RequestType, opt => opt.MapFrom(src => src.Type))
                 .ForMember(dest => dest.RequestStatus, opt => opt.MapFrom(src => src.Status))
                 .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.Date))
                ;

            cfg.CreateMap<AccountRequestEntity, AccountRequestDto>()
                .ForMember(dest => dest.SubType, opt => opt.MapFrom(src => src.AccountRequestType))
               ;
            cfg.CreateMap<AccountRequestDto, AccountRequestEntity>()
                .ForMember(dest => dest.AccountRequestType, opt => opt.MapFrom(src => src.SubType))
                ;

            cfg.CreateMap<AccountRequestEntity, AccountNewRequestDto>()
               ;
            cfg.CreateMap<AccountNewRequestDto, AccountRequestEntity>()
                ;

            cfg.CreateMap<CardRequestEntity, CardRequestDto>()
                .ForMember(dest => dest.SubType, opt => opt.MapFrom(src => src.CardRequestType))
               ;
            cfg.CreateMap<CardRequestDto, CardRequestEntity>()
                .ForMember(dest => dest.CardRequestType, opt => opt.MapFrom(src => src.SubType))
                ;

            cfg.CreateMap<CardLimitRequestEntity, CardLimitRequestDto>()
                ;
            cfg.CreateMap<CardLimitRequestDto, CardLimitRequestEntity>()
                ;

            cfg.CreateMap<CardReissueRequestEntity, CardReissueRequestDto>()
                .ForMember(dest => dest.ReissueType, opt => opt.MapFrom(src => src.CardReissueType))
                .ForMember(dest => dest.Reason, opt => opt.MapFrom(src => src.CardReissueReason))
                ;
            cfg.CreateMap<CardReissueRequestDto, CardReissueRequestEntity>()
                .ForMember(dest => dest.CardReissueType, opt => opt.MapFrom(src => src.ReissueType))
                .ForMember(dest => dest.CardReissueReason, opt => opt.MapFrom(src => src.Reason))
                ;

            cfg.CreateMap<CardNewRequestEntity, CardNewRequestDto>()
                ;
            cfg.CreateMap<CardNewRequestDto, CardNewRequestEntity>()
                ;

            cfg.CreateMap<CardBlockRequestEntity, CardBlockRequestDto>()
                ;
            cfg.CreateMap<CardBlockRequestDto, CardBlockRequestEntity>()
                ;

        }
    }
}