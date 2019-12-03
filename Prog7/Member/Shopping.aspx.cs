using Program6.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program6.Prog7.Member
{
    public partial class Shopping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            IDtxt.ReadOnly = false;
            Quantitytxt.ReadOnly = false;
            btnAdd.Enabled = false;
        }

        protected void IDtxt_TextChanged(object sender, EventArgs e)
        {
            int index = 0;
            try
            {
                SQLDataClass.getProduct(IDtxt.Text, ref index);
                System.Data.DataRow row = SQLDataClass.tblProduct.Rows[index];
                Nametxt.Text = row[1].ToString();

            }
            catch (Exception ex)
            {

            }


        }

        protected void btnCompute_Click(object sender, EventArgs e)
        {
            if (btnCompute.Text == "Calculate")
            {
                IDtxt.ReadOnly = true;
                Quantitytxt.ReadOnly = true;
                double price = Int32.Parse(Pricetxt.Text);
                Double Tax = .5;
                int quantity = Int32.Parse(Quantitytxt.Text);
                try
                {
                    double subtot = price * quantity;
                    double Total = subtot * Tax;
                    SubTotaltxt.Text = subtot.ToString();
                    Taxtxt.Text = Tax.ToString();
                    SQLDataClass.NewItem(IDtxt.Text, Nametxt.Text, price, quantity, Total);
                    IDtxt.ReadOnly = true;
                    Pricetxt.ReadOnly = true;
                    Quantitytxt.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Resetbtn.Focus();
                btnCompute.Text = "Clear";
                btnAdd.Enabled = true;
            }
            else if (btnCompute.Text == "Clear")
            {
                btnCompute.Text = "Calculate";
                IDtxt.ReadOnly = false;
                Quantitytxt.ReadOnly = false;
                btnAdd.Enabled = false;
            }
        }

        protected void Resetbtn_Click(object sender, EventArgs e)
        {
            SubTotaltxt.Text = "";
            Taxtxt.Text = "";
            IDtxt.Text = "";
            Pricetxt.Text = "";
            Quantitytxt.Text = "";

            IDtxt.ReadOnly = false;
            Pricetxt.ReadOnly = false;
            Quantitytxt.ReadOnly = false;
        }


        protected void btnFind_Click1(object sender, EventArgs e)
        {
            int index = 0;
            try
            {
                SQLDataClass.getProduct(IDtxt.Text, ref index);
                System.Data.DataRow row = SQLDataClass.tblProduct.Rows[index];
                Nametxt.Text = row[1].ToString();

            }
            catch (Exception ex)
            {

            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            double price = Int32.Parse(Pricetxt.Text);           
            int quantity = Int32.Parse(Quantitytxt.Text);
            double subtot = price * quantity;
            try
            {
                SQLDataClass.NewItem(IDtxt.Text, Nametxt.Text, price, quantity, subtot);
                btnAdd.Enabled = false;
                IDtxt.ReadOnly = false;
                Pricetxt.ReadOnly = false;
                btnCompute.Text = "Calculate";
                SubTotaltxt.Text = "";
                Taxtxt.Text = "";
                IDtxt.Text = "";
                Pricetxt.Text = "";
                Quantitytxt.Text = "";
                IDtxt.Focus();
            }
            catch (Exception ex)
            {

            }

        }
    }
}
