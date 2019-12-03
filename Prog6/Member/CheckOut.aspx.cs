using Program6.App_Code;
using Program6.Prog7;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program6.Prog6.Member
{
    public partial class CheckOut : System.Web.UI.Page
    {
        private GridViewRow row;

        protected void Page_Load(object sender, EventArgs e)
        {


            SQLDataClass.setupAdapter();
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            int index = 0;
            string cost;
            double price = 0;
            double total = 0;
            if (index == 0)
            {
                Response.Write("Purchase an item first!");
            }
            else
            {
                System.Data.DataRow row = SQLDataClass.tblBag.Rows[index];
                while (index <= SQLDataClass.tblBag.Rows.Count - 1)
                {
                    cost = string.Format("{0:C}", row[4]);
                    price = Convert.ToDouble(cost);
                    total += price;
                    index++;
                    if (index <= SQLDataClass.tblBag.Rows.Count - 1)
                    {
                        row = SQLDataClass.tblBag.Rows[index];
                    }
                }
                totaltxt.Text = total.ToString();
            }
        }

        protected void btnCompute_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}