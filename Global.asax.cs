using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Program6.App_Code;
namespace Program6
{
    public class Global : System.Web.HttpApplication
    {

        protected double Tax = .5;
        protected void Application_Start(object sender, EventArgs e)
        {            
            
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["Prog7_Bag"] = SQLDataClass.NewShoppingBag();
            Session["Prog7_ID"] = "";
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