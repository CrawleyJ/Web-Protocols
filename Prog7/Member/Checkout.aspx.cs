using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program6.Prog7.Member
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable theTable = (DataTable)Session["Prog5_Bag"];
            DataRow row;
            double total = 0;

            Prog7_ShoppingItem item;
            Control theForm = Master.Master.FindControl("form1");


            for (int i = 0; i < theTable.Rows.Count; i++)
            {
                row = theTable.Rows[i];
                item = (Prog7_ShoppingItem)LoadControl("Prog7_ShoppingItem.ascx");
                item.TheID = row[0].ToString();
                item.TheName = row[1].ToString();
                item.TheQuantity = int.Parse(row[2].ToString());
                item.ThePrice = row[3].ToString().Remove(0, 1);
                item.TheCost = row[4].ToString().Remove(0, 1);
                total += Convert.ToDouble(item.TheCost);
                theForm.Controls.Add(item);            
            }

            totaltxt.Text = string.Format("{0:C}", total);
        }

        protected void btnCompute_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}