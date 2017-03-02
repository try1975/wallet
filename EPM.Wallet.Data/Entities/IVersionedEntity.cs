// IVersionedEntity.cs
// Copyright Jamie Kurtz, Brian Wortman 2014.

namespace EPM.Wallet.Data.Entities
{
    public interface IVersionedEntity
    {
        byte[] Version { get; set; }
    }
}