using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using WalletWebApi.Model;

namespace WalletWebApi.AutoMappers
{
    public static class RequisiteAutoMapper
    {
        public static void Configure(MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<RequisiteEntity, RequisiteDto>()
                ;
            cfg.CreateMap<RequisiteDto, RequisiteEntity>()
                ;
        }
    }
}