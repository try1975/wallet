using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using WalletWebApi.Model;

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
            cfg.CreateMap<StandingOrderEntity, StandingOrderInfoDto>()
              ;
            cfg.CreateMap<StandingOrderInfoDto, StandingOrderEntity>()
                ;
        }
    }
}