namespace EPM.Wallet.Common
{
    public static class WalletConstants
    {
        public static class ClientAppApi
        {
            public const string ApiSegmentName = "api/";

            public const string Banks = ApiSegmentName + nameof(Banks);
            public const string BankAccounts = ApiSegmentName + nameof(BankAccounts);
            public const string Currencies = ApiSegmentName + nameof(Currencies);

            public const string Clients = ApiSegmentName + nameof(Clients);
            private const string ByClient = ApiSegmentName + nameof(Clients) + "/{" + nameof(Ro.ClientId) + "}/";

            public const string Accounts = ApiSegmentName + nameof(Accounts);
            public const string AccountsByClient = ByClient + nameof(Accounts);


            public const string ClientAccountStatuses = ApiSegmentName + nameof(ClientAccountStatuses);

            public const string Cards = ApiSegmentName + nameof(Cards);
            public const string CardsByClient = ByClient + nameof(Cards);

            public const string Messages = ApiSegmentName + nameof(Messages);
            public const string MessagesByClient = ByClient + nameof(Messages);

            public const string Requisites = ApiSegmentName + nameof(Requisites);
            public const string RequisitesByClient = ByClient + nameof(Requisites);

            public const string Requests = ApiSegmentName + nameof(Requests);
            public const string RequestsByClient = ByClient + nameof(Requests);


            public const string StandingOrders = ApiSegmentName + nameof(StandingOrders);
            public const string StandingOrdersByClient = ByClient + nameof(StandingOrders);
        }

        public static class MessagesByClientRoutes
        {
            public const string UnreadCount = nameof(UnreadCount);
            public const string Outgoing = nameof(Outgoing);
            public const string Incomming = nameof(Incomming);
        }

        public static class CardsByClientRoutes
        {
            public const string SetLimit = nameof(SetLimit);
            public const string New =  nameof(New);
            public const string Block = nameof(Block);
            public const string Reissue =  nameof(Reissue);
        }

        public static class AccountByClientRoutes
        {
            public const string New = nameof(New);
            public const string Refill = nameof(Refill);
            public const string TransferToCard = nameof(TransferToCard);
            public const string TransferOut = nameof(TransferOut);
        }

        public static class WebUsersAndRoles
        {
            public const string AdminUser = nameof(AdminUser);
            public const string AdminRole = nameof(AdminRole);
        }

        public static class TokenTypes
        {
            public const string ExternalToken = nameof(ExternalToken);
            public const string InternalToken = nameof(InternalToken);
        }
    }
}