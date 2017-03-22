namespace EPM.Wallet.Common.Enums
{
    public enum RequestStatus
    {
        Unknown,
        Pending,
        Processed, 
        Rejected
    }

    public static class RequestStatuses
    {
        public static RequestStatus GetPendingRequestStatus()
        {
            return RequestStatus.Pending;
        }

        public static RequestStatus GetProcessedRequestStatus()
        {
            return RequestStatus.Processed;
        }

        public static RequestStatus GetRejectedRequestStatus()
        {
            return RequestStatus.Rejected;
        }

        public static bool VisibleForClient(RequestStatus requestStatus)
        {
            return ((requestStatus == RequestStatus.Pending) || (requestStatus == RequestStatus.Rejected));
        }
    }
}