using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TinyUrlConversationApp.App_Start;

namespace TinyUrlConversationApp
{
    public class Global : System.Web.HttpApplication
    {
        public object WebApiConfig { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            GlobalConfiguration.Configure(TinyUrlConversationApp.App_Start.WebApiConfig.Register);
            
        }
    }
}
