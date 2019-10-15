using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;


public static class constants
{
   public const double Tax = .055;

}

 

namespace Prog2
{
   

   public partial class OrderingProduct : System.Web.UI.Page
   {
      
         protected void Page_Load(object sender, EventArgs e)
      {
         if(IDtxt.Text != "")
         {
            IDtxt.ReadOnly = true;
            Pricetxt.ReadOnly = true;
            Quantitytxt.ReadOnly = true;
         }
         if(!IsPostBack)
         {
            SubTotaltxt.Text = GlobalClass.GlobalSub;
            Taxtxt.Text = GlobalClass.GlobalTax;
            GrandTotaltxt.Text = GlobalClass.GlobalTotal;
            IDtxt.Text = GlobalClass.GlobalID;
            Pricetxt.Text = GlobalClass.GlobalPrice;
            Quantitytxt.Text = GlobalClass.GlobalQuan;
         }       

      }
      

      protected void btnCompute_Click(object sender, EventArgs e)
      {
         
         string price = Pricetxt.Text;
         string quantity = Quantitytxt.Text;
         try {
            double subtot = Int32.Parse(price) * Int32.Parse(quantity);
            double Total = subtot * constants.Tax;
            SubTotaltxt.Text = subtot.ToString();            
            Taxtxt.Text = constants.Tax.ToString();
            GrandTotaltxt.Text = Total.ToString();
            IDtxt.ReadOnly = true;
            Pricetxt.ReadOnly = true;
            Quantitytxt.ReadOnly = true;
         }
         catch(Exception ex)
         {
            Console.WriteLine(ex.Message);
         }
         Resetbtn.Focus();
         GlobalClass.GlobalSub = SubTotaltxt.Text;
         GlobalClass.GlobalTax = Taxtxt.Text;
         GlobalClass.GlobalTotal = GrandTotaltxt.Text;
         GlobalClass.GlobalID = IDtxt.Text;
         GlobalClass.GlobalPrice = Pricetxt.Text;
         GlobalClass.GlobalQuan = Quantitytxt.Text;

      }

      protected void Resetbtn_Click(object sender, EventArgs e)
      {
         SubTotaltxt.Text = "";
         Taxtxt.Text = "";
         GrandTotaltxt.Text = "";
         IDtxt.Text = "";
         Pricetxt.Text = "";
         Quantitytxt.Text = "";
         GlobalClass.GlobalSub = SubTotaltxt.Text;
         GlobalClass.GlobalTax = Taxtxt.Text;
         GlobalClass.GlobalTotal = GrandTotaltxt.Text;
         GlobalClass.GlobalID = IDtxt.Text;
         GlobalClass.GlobalPrice = Pricetxt.Text;
         GlobalClass.GlobalQuan = Quantitytxt.Text;
         IDtxt.ReadOnly = false;
         Pricetxt.ReadOnly = false;
         Quantitytxt.ReadOnly = false;
      }

      protected void IDtxt_TextChanged(object sender, EventArgs e)
      {
         GlobalClass.GlobalID = IDtxt.Text;
      }

      protected void Pricetxt_TextChanged(object sender, EventArgs e)
      {
         GlobalClass.GlobalPrice = Pricetxt.Text;
      }

      protected void Quantitytxt_TextChanged(object sender, EventArgs e)
      {
         GlobalClass.GlobalQuan = Quantitytxt.Text;
      }
   }
}