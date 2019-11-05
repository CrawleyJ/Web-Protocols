using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrawleyJ_Prog5.Prog5;

namespace CrawleyJ_Prog5.Main
{
   public partial class Login : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
      }

      protected void LinkButton1_Click(object sender, EventArgs e)
      {
         Response.Redirect("CreateUser.aspx");
      }

      protected void btnLogin_Click(object sender, EventArgs e)
      {
         SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ShoppingBagConnectionString"].ConnectionString);
         conn.Open();
         string checkuser = "select count(*) from Users where UserName='" + txtUser.Text + "'";
         SqlCommand com = new SqlCommand(checkuser, conn);
         int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
         conn.Close();
         if (temp == 1)
         {
            conn.Open();
            string checkPasswordQuery = "select Password from Users where UserName='" + txtUser.Text + "'";
            SqlCommand passCom = new SqlCommand(checkPasswordQuery, conn);
            String password = passCom.ExecuteScalar().ToString().Replace(" ", "");
            if (password == txtPass.Text)
            {
               Session["New"] = txtUser.Text;
               Response.Write("Password is correct!");
               Response.Redirect("/Prog5/Default.aspx");
            }
            else
            {
               Response.Write("Password is Not correct!");
            }
         }
         else
         {
            Response.Write("User ID is not registered!");
         }

         conn.Close();
      }
   }
}