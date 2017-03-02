using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.AutoMappers
{
    public static class BankAutoMapper
    {
        public static void Configure(MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<BankEntity, BankDto>()
                ;
            //cfg.CreateMap<IEnumerable<BankEntity>, IEnumerable<Bank>>()
            //    ;
            cfg.CreateMap<BankDto, BankEntity>()
                ;

            //cfg.CreateMap<BankEntity, BankOne>()
            //    .AfterMap((src, dest) =>
            //    {
            //        foreach (var i in dest.BankAccounts) i.Bank = dest;
            //    })
            //    ;
            //cfg.CreateMap<BankOne, BankEntity>()
            //    ;
        }
    }
}