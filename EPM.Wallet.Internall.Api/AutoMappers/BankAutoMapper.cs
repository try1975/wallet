using AutoMapper.Configuration;
using EPM.Wallet.Common.Model;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Internall.Api.AutoMappers
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