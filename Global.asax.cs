using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace project5
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            HttpCookie decryptedCookie =
           Context.Request.Cookies[FormsAuthentication.FormsCookieName];
            if (decryptedCookie != null)
            {
                FormsAuthenticationTicket ticket =
                    FormsAuthentication.Decrypt(decryptedCookie.Value);

                var identity = new GenericIdentity(ticket.Name);
                var roles = ticket.UserData.Split(',');
                var principal = new GenericPrincipal(identity, roles);

                HttpContext.Current.User = principal;
                Thread.CurrentPrincipal = HttpContext.Current.User;
            }
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