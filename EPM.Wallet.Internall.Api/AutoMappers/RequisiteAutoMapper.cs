using AutoMapper.Configuration;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.AutoMappers
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