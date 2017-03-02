using AutoMapper.Configuration;
using EPM.Wallet.Common.Model;
using EPM.Wallet.Data.Entities;

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