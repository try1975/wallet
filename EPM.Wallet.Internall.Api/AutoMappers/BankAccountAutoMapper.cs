using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.AutoMappers
{
    public class BankAccountAutoMapper
    {
        public static void Configure(MapperConfigurationExpression cfg)
        {
            
            cfg.CreateMap<BankAccountEntity, BankAccountDto>()
                ;
            //cfg.CreateMap<IEnumerable<BankAccountEntity>, IEnumerable<BankAccount>>()
            //    ;

            cfg.CreateMap<BankAccountDto, BankAccountEntity>()
                ;
        }
    }
}