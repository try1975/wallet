using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.AutoMappers
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