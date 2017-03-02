using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.AutoMappers
{
    public class AccountAutoMapper
    {
        public static void Configure(MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<ClientAccountEntity, AccountDto>()
                ;
            ;
            cfg.CreateMap<AccountDto, ClientAccountEntity>() 
                ;
            cfg.CreateMap<ClientAccountStatusEntity, ClientAccountStatusDto>()
                ;
            cfg.CreateMap<ClientAccountStatusDto, ClientAccountStatusEntity>()
                ;
        }
    }
}