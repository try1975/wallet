namespace EPM.Wallet.Common.Enums
{
    //[JsonConverter(typeof(AccountRequestTypeJsonConverter))]
    //[JsonConverter(typeof(StringEnumConverter))]
    public enum AccountRequestType
    {
        Unknown,
        New,
        Refill,
        //[EnumMember(Value = "Transfer To Card")]
        TransferToCard,
        //[EnumMember(Value = "Transfer Out")]
        TransferOut,
        //[EnumMember(Value = "Account TopUp")]
        AccountTopUp
    }

    //public class AccountRequestTypeJsonConverter: JsonConverter
    //{
    //    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override bool CanConvert(Type objectType)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}
}