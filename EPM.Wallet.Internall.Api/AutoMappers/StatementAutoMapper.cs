using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.AutoMappers
{
    public static class StatementAutoMapper
    {
        public static void Configure(MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<StatementEntity, StatementDto>()
               ;
            cfg.CreateMap<StatementDto, StatementEntity>()
               ;

            cfg.CreateMap<AccountStatementDataDto, StatementEntity>()
               ;
        }
    }
}