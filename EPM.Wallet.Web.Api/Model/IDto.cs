namespace WalletWebApi.Model
{
    public interface IDto<T>
    {
        T Id { get; set; }
    }
}