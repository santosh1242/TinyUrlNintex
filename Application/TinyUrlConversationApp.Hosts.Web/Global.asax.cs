using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;

namespace TinyUrlConversationApp.Hosts.Web
{
    public class Global : System.Web.HttpApplication
    {
        public object WebApiConfig { get; private set; }
        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(TinyUrlConversationApp.Hosts.Web.App_Start.WebApiConfig.Register);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}