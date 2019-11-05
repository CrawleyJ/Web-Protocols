using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrawleyJ_Prog5.App_Code;
using CrawleyJ_Prog5.Main;
namespace CrawleyJ_Prog5.Prog5
{
   public partial class Checkout : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {

      }

      //This will terminate the current session and go back to the login page.
      protected void btnCompute_Click(object sender, EventArgs e)
      {
         SQLDataClass.ClearBag();
         Response.Redirect("/Main/Default.aspx");
         
      }

      protected void Button1_Click(object sender, EventArgs e)
      {
         SQLDataClass.ClearBag();
         Response.Redirect("/Main/Login.aspx");

      }
   }
}