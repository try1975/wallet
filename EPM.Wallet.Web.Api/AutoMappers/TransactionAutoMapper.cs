using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using WalletWebApi.Model;

namespace WalletWebApi.AutoMappers
{
    public static class TransactionAutoMapper
    {
        public static void Configure(MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<TransactionEntity, TransactionDto>()
               ;
            cfg.CreateMap<TransactionDto, TransactionEntity>()
                ;
        }
    }
}