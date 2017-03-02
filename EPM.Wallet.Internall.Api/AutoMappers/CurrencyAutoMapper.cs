using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.Internall.Api.AutoMappers
{
    public class CurrencyAutoMapper
    {
        public static void Configure(MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<CurrencyEntity, CurrencyDto>()
                ;
            cfg.CreateMap<CurrencyDto, CurrencyEntity>()
                ;
        }
    }
}