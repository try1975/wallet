using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.AutoMappers
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