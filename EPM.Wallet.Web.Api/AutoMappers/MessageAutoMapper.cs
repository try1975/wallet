using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using WalletWebApi.Model;

namespace WalletWebApi.AutoMappers
{
    public static class MessageAutoMapper
    {
        public static void Configure(MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<MessageEntity, MessageDto>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.CreatedAt))
                ;
            cfg.CreateMap<MessageDto, MessageEntity>()
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.Date))
                ;
        }
    }
}