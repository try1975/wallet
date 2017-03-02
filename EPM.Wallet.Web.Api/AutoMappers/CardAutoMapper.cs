using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using WalletWebApi.Model;

namespace WalletWebApi.AutoMappers
{
    public static class CardAutoMapper
    {
        public static void Configure(MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<CardEntity, CardDto>()
                //.ForMember(opt => opt.Client, x => x.Ignore())
                ;
            cfg.CreateMap<CardDto, CardEntity>()
                ;
        }
    }
}