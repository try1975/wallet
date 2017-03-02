namespace EPM.Wallet.Data.Entities
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}