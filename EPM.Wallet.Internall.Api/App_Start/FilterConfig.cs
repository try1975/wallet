using System.Web;
using System.Web.Mvc;

namespace EPM.Wallet.Internall.Api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
