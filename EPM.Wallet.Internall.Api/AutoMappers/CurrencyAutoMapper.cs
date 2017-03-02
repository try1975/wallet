using AutoMapper.Configuration;
using EPM.Wallet.Common.Model;
using EPM.Wallet.Data.Entities;

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