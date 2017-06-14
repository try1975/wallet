using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.AutoMappers
{
    public static class DirectDebitAutoMapper
    {
        public static void Configure(MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<DirectDebitEntity, DirectDebitDto>()
               ;
            cfg.CreateMap<DirectDebitDto, DirectDebitEntity>()
                ;
        }
    }
}