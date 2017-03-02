using AutoMapper.Configuration;
using EPM.Wallet.Common.Model;
using EPM.Wallet.Data.Entities;

namespace WalletWebApi.AutoMappers
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