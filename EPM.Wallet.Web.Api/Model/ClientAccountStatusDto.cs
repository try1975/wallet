namespace WalletWebApi.Model
{
    public class ClientAccountStatusDto : IDto<string>
    {
        public string Id { get;set;}
        public string Name { get; set; }
    }
}