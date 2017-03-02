using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.AutoMappers
{
    public static class ClientAutoMapper
    {
        public static void Configure(MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<ClientEntity, ClientDto>()
                //.AfterMap((src, dest) =>
                //{
                //    foreach (var i in dest.ClientAccounts) i.Client = dest;
                //})
                //.AfterMap((src, dest) =>
                //{
                //    foreach (var i in dest.Cards) i.Client = dest;
                //})
                ;
                  cfg.CreateMap<ClientDto, ClientEntity>()
                //.ForMember(opt=>opt.Cards, x=>x.Ignore())
                ;
        }
    }
}