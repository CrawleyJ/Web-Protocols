using CrawleyJ_Prog5.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrawleyJ_Prog5.Prog6.Member
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int index = 0;
            string cost;            
            double price = 0;
            double total = 0;
            System.Data.DataRow row = SQLDataClass.tblBag.Rows[index];
            while (index <= SQLDataClass.tblBag.Rows.Count - 1)
            {
                cost = string.Format("{0:C}", row[4]);
                price = Convert.ToDouble(cost);
                total += price;
            }
            totaltxt.Text = total.ToString();
        }

        protected void btnCompute_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}