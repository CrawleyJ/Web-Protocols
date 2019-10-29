using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrawleyJ_Prog3.App_Code
{
   public class SQLDataClass
   {
      private const string ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nigger_sauraus\source\repos\CrawleyJ_Prog3\UWPCS3870.mdf;Integrated Security = True; Connect Timeout = 30";
      private static System.Data.SqlClient.SqlDataAdapter prodAdapter;
      private static System.Data.SqlClient.SqlCommand prodCmd = new System.Data.SqlClient.SqlCommand();
      private static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
      public static System.Data.DataTable tblProduct = new System.Data.DataTable("Product");


      public static void setupProdAdapter()
      {
         con.ConnectionString = ConStr;
         prodCmd.Connection = con;
         prodCmd.CommandType = System.Data.CommandType.Text;
         prodCmd.CommandText = "Select * from Product order by ProductID";
         prodAdapter = new System.Data.SqlClient.SqlDataAdapter(prodCmd);
         prodAdapter.FillSchema(tblProduct, System.Data.SchemaType.Source);
      }

      public static void getAllProducts()
      {
         if (prodAdapter == null)
            setupProdAdapter();        
                  
         prodCmd.CommandText = "Select * from Product order by ProductID";
         try
         {
            
            if (!(tblProduct == null))
               tblProduct.Clear();
            prodAdapter.Fill(tblProduct);
         }
         catch (Exception e)
         {
            throw e;
         } finally
         {
            con.Close();
         }
      }

      public static void getProduct(string theID, ref int index)
      {
         try
         {
            prodCmd.CommandText = "Select * from Product Where ProductID = '" + theID + "'";
            prodAdapter.Fill(tblProduct);
            index = tblProduct.Rows.Count;
         }
         catch (Exception e)
         {
            throw e;
         }
         finally
         {
            con.Close();
         }

      }
      public static void UpdateProduct(string theID, string newName, double newPrice, string newDesc)
      {
         prodCmd.CommandText = "UPDATE Product SET ProductName = @newname, UnitPrice = @Price, Description = @Desc Where ProductID = @ID ";
         try {
            prodCmd.Parameters.AddWithValue("@ID", theID);
            prodCmd.Parameters.AddWithValue("@newname", newName);
            prodCmd.Parameters.AddWithValue("@Price", newPrice);
            prodCmd.Parameters.AddWithValue("@Desc", newDesc);
            con.Open();
            prodCmd.ExecuteNonQuery();
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }
         finally
         {
            con.Close();
         }
      }

      public static void NewProduct(string theID, string newName, double newPrice, string newDesc)
      {
        
         try
         {
            string stmt = "INSERT INTO Product(ProductID, ProductName, UnitPrice, Description) VALUES (@UProductID, @UProductName, @UUnitPrice, @UDescription)";
            con.Open();
            prodCmd = new System.Data.SqlClient.SqlCommand(stmt, con);
            prodCmd.Parameters.AddWithValue("@UProductID", theID);
            prodCmd.Parameters.AddWithValue("@UProductName", newName);
            prodCmd.Parameters.AddWithValue("@UUnitPrice", newPrice);
            prodCmd.Parameters.AddWithValue("@UDescription", newDesc);            
            prodCmd.ExecuteNonQuery();
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }
         finally
         {
            con.Close();
         }
      }

      public static void DeleteProduct(string theID)
      {
         prodCmd.CommandText = "DELETE FROM Product Where ProductID = '" + theID + "'";
         try
         {
            con.Open();
            prodCmd.ExecuteNonQuery();
         }
         catch (Exception ex)
         {
            throw new Exception(ex.Message);
         }
         finally
         {
            con.Close();
         }
      }



   }
}