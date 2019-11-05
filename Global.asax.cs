using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using CrawleyJ_Prog5.App_Code;
namespace CrawleyJ_Prog5
{
   public class Global : System.Web.HttpApplication
   {

      protected double Tax = .5;
      protected void Application_Start(object sender, EventArgs e)
      {
         SQLDataClass.setupProdAdapter();
      }

      protected void Session_Start(object sender, EventArgs e)
      {
         Session["Prog3_Index"] = 0;
         Session["Prog3_ID"] = "";
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