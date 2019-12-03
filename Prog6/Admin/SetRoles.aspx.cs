using Program6.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program6.Prog6.Admin
{
    public partial class SetRoles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            if (!IsPostBack)
            {
                DisplayRow((int)Session["Prog3_Index"]);
            }
            EnableDisableButtons();
        }

        private void DisplayRow(int index)
        {
            System.Data.DataRow row = SQLDataClass.tblUsers.Rows[index];
            Usertxt.Text = row[0].ToString();
            Emailtxt.Text = row[1].ToString();
            Roletxt.Text = string.Format("{0:C}", row[2]);

            EnableDisableButtons();
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            int index = (int)Session["Prog3_Index"] + 1;
            if (index > SQLDataClass.tblUsers.Rows.Count - 1)
                index = SQLDataClass.tblUsers.Rows.Count - 1;
            Session["Prog3_Index"] = index;
            DisplayRow(index);
        }
        private void EnableDisableButtons()
        {
            int curIndex = (int)Session["Prog3_Index"];
            if (curIndex > 0)
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
            }
            else
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
            }
            if (curIndex < SQLDataClass.tblUsers.Rows.Count - 1)
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            int index = (int)Session["Prog3_Index"] - 1;
            if (index < 0)
                index = 0;
            Session["Prog3_Index"] = index;
            DisplayRow(index);
            EnableDisableButtons();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string User = Usertxt.Text;
                string role = Roletxt.Text;
                SQLDataClass.UpdateUsers(User, role);
                txtMessage.Text = "Record updated.";
                SQLDataClass.getAllProducts();
            }
            catch (Exception ex)
            {
                txtMessage.Text = "Product Not Updated: " + ex.Message;
            }
            EnableDisableButtons();
        }






        protected void btnFirst_Click(object sender, EventArgs e)
        {
            int index = 0;
            Session["Prog3_Index"] = 0;
            DisplayRow(index);
            EnableDisableButtons();
        }

        protected void btnLast_Click(object sender, EventArgs e)
        {
            int index = (int)Session["Prog3_Index"] - 1;
            Session["Prog3_Index"] = index;
            DisplayRow(index);
            EnableDisableButtons();
        }
    }
}