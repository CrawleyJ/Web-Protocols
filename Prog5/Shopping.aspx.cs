using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrawleyJ_Prog5.App_Code;
namespace CrawleyJ_Prog5.Prog5
{
   public partial class Shopping : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
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
         double price = Convert.ToDouble(Pricetxt.Text);
         Double Tax = .5;
         int quantity = Convert.ToInt32(Quantitytxt.Text);
         
         try
         {
            double subtot = price * quantity;
            double Total = subtot * Tax;
            SubTotaltxt0.Text = subtot.ToString();
            SubTotaltxt.Text = Tax.ToString();
            Taxtxt.Text = Total.ToString();
            IDtxt.ReadOnly = true;
            Pricetxt.ReadOnly = true;
            Quantitytxt.ReadOnly = true;
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
         }
         Resetbtn.Focus();
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
            System.Data.DataRow row = SQLDataClass.tblProduct.Rows[index - 1];
            Nametxt.Text = row[1].ToString();
            Pricetxt.Text = row[2].ToString();
         }
         catch (Exception ex)
         {
            Taxtxt.Text = ex.ToString();
         }
      }

      protected void btnAdd_Click(object sender, EventArgs e)
      {
         try
         {
            string theID = IDtxt.Text;
            string newName = Nametxt.Text;
            int Quantity = int.Parse(Quantitytxt.Text);
            double Price = double.Parse(Pricetxt.Text.Replace("$", ""));
            double Cost = double.Parse(SubTotaltxt0.Text.Replace("$", ""));
            SQLDataClass.NewPurchase(theID, newName, Price, Quantity, Cost);            
         }
         catch (Exception ex)
         {            
         }
         
      }
   }
}