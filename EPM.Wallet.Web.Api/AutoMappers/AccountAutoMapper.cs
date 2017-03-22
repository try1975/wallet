using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using WalletWebApi.Model;

namespace WalletWebApi.AutoMappers
{
    public class AccountAutoMapper
    {
        public static void Configure(MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<ClientAccountEntity, AccountDto>()
                ;
            cfg.CreateMap<AccountDto, ClientAccountEntity>() 
                ;
        }
    }
}