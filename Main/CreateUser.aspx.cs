using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program6.Main
{
    public partial class CreateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (IsPostBack)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ShoppingBagConnectionString"].ConnectionString);
                conn.Open();
                string checkuser = "select count(*) from Users where UserName='" + txtUser.Text + "'";
                SqlCommand com = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                conn.Close();
                if (temp == 1)
                {
                    Response.Write("User already existis!");
                }
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Guid newGuid = Guid.NewGuid();
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ShoppingBagConnectionString"].ConnectionString);
                conn.Open();
                string insertQuery = "INSERT INTO Users(UserName, Password, Email, Favorite) VALUES (@User, @UPass, @UEmail, @UFav)";

                SqlCommand com = new SqlCommand(insertQuery, conn);
                com.Parameters.AddWithValue("@User", txtUser.Text);
                com.Parameters.AddWithValue("@UPass", txtPass.Text);
                com.Parameters.AddWithValue("@UEmail", txtEmail.Text);
                com.Parameters.AddWithValue("@UFav", txtFav.Text);
                com.ExecuteNonQuery();
                Response.Write("Registeration is done!");
                Response.Redirect("Login.aspx");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
        }
    }
}
