using CrawleyJ_Prog3.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrawleyJ_Prog3
{
   public partial class Updating : System.Web.UI.Page
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
         System.Data.DataRow row = SQLDataClass.tblProduct.Rows[index];
         Idtxt.Text = row[0].ToString();
         Nametxt.Text = row[1].ToString();
         Pricetxt.Text = string.Format("{0:C}", row[2]);
         Desctxt.Text = row[3].ToString();
         EnableDisableButtons();
      }

      protected void btnNext_Click(object sender, EventArgs e)
      {
         int index = (int)Session["Prog3_Index"] + 1;
         if (index > SQLDataClass.tblProduct.Rows.Count - 1)
            index = SQLDataClass.tblProduct.Rows.Count - 1;
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
         if (curIndex < SQLDataClass.tblProduct.Rows.Count - 1)
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
            string theID = Idtxt.Text;
            string newName = Nametxt.Text;
            double newPrice = double.Parse(Pricetxt.Text.Replace("$", ""));
            string newDesc = Desctxt.Text;
            SQLDataClass.UpdateProduct(theID, newName, newPrice, newDesc);
            txtMessage.Text = "Record updated.";
            SQLDataClass.getAllProducts();
         }
         catch (Exception ex)
         {
            txtMessage.Text = "Product Not Updated: " + ex.Message;
         }
         EnableDisableButtons();
      }
  

      protected void btnNew_Click(object sender, EventArgs e)
      {
         if (btnNew.Text == "New")
         {
            Idtxt.Text = "";
            Nametxt.Text = "";
            Pricetxt.Text = "";
            Desctxt.Text = "";
            btnNew.Text = "Save";
            
         }
         else if (btnNew.Text == "Save")
         {
            try
            {
               string theID = Idtxt.Text;
               string newName = Nametxt.Text;
               double newPrice = double.Parse(Pricetxt.Text.Replace("$", ""));
               string newDesc = Desctxt.Text;
               SQLDataClass.NewProduct(theID, newName, newPrice, newDesc);
               btnNew.Text = "New";
               Nametxt.ReadOnly = true;
               Pricetxt.ReadOnly = true;
               Desctxt.ReadOnly = true;
               Idtxt.ReadOnly = true;
               txtMessage.Text = "Record added.";
               SQLDataClass.getAllProducts();
            }
            catch (Exception ex)
            {
               txtMessage.Text = "Product Not added: " + ex.Message;
               int index = (int)Session["Prog3_Index"] - 1;
               if (index < 0)
                  index = 0;
               Session["Prog3_Index"] = index;
               DisplayRow(index);               
            }
            EnableDisableButtons();
         }
      }

      protected void btnDelete_Click(object sender, EventArgs e)
      {
         try
         {
            string theID = Idtxt.Text;
            SQLDataClass.DeleteProduct(theID);
            txtMessage.Text = "Record Deleted.";
            SQLDataClass.getAllProducts();
         }
         catch (Exception ex)
         {
            txtMessage.Text = "Product Not deleted: " + ex.Message;
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