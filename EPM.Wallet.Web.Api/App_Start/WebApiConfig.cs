using System.Web.Http;
//using Microsoft.Owin.Security.OAuth;

namespace WalletWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            //config.SuppressDefaultHostAuthentication();
            //config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.Routes.MapHttpRoute(
            //    name: "EpmApi",
            //    routeTemplate: "epm/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "OneLevelNested",
            //    routeTemplate: "{controller}/{bankId:int}/{action}/{id}",
            //    defaults: new { id = RouteParameter.Optional, bankId = RouteParameter.Optional }
            //);


            config.Formatters.XmlFormatter.UseXmlSerializer = true;


        }
    }
}
