using AutoMapper.Configuration;
using EPM.Wallet.Common.Model;
using EPM.Wallet.Data.Entities;

namespace WalletWebApi.AutoMappers
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