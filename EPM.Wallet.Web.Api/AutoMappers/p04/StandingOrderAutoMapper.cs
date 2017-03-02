using AutoMapper.Configuration;
using EPM.Wallet.Common.Model;
using EPM.Wallet.Data.Entities;

namespace WalletWebApi.AutoMappers
{
    public static class StandingOrderAutoMapper
    {
        public static void Configure(MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<StandingOrderEntity, StandingOrderDto>()
               ;
            cfg.CreateMap<StandingOrderDto, StandingOrderEntity>()
                ;
        }
    }
}