using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using WalletWebApi.Model;

namespace WalletWebApi.AutoMappers
{
    public class DirectDebitAutoMapper
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