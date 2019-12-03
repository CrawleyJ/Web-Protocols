using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6.App_Code
{
    class SQLDataClass
    {
        private const string ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=J:\Web Protocols, tech & App\CrawleyJ_Prog5\ShoppingBag.mdf;Integrated Security=True;Connect Timeout=30";
        private static System.Data.SqlClient.SqlDataAdapter prodAdapter;
        private static System.Data.SqlClient.SqlDataAdapter UserAdapter;
        private static System.Data.SqlClient.SqlDataAdapter BagAdapter;
        private static System.Data.SqlClient.SqlCommand prodCmd = new System.Data.SqlClient.SqlCommand();
        private static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.DataTable tblProduct = new System.Data.DataTable("Product");
        public static System.Data.DataTable tblBag = new System.Data.DataTable("ShoppingBag");
        private static System.Data.SqlClient.SqlCommand BagCmd = new System.Data.SqlClient.SqlCommand();
        public static System.Data.DataTable tblUsers = new System.Data.DataTable("Users");
        private static System.Data.SqlClient.SqlCommand UserCmd = new System.Data.SqlClient.SqlCommand();

        public static void setupProdAdapter()
        {

            con.ConnectionString = ConStr;
            prodCmd.Connection = con;
            prodCmd.CommandType = System.Data.CommandType.Text;
            prodCmd.CommandText = "Select * from Product order by ProductID";
            prodAdapter = new System.Data.SqlClient.SqlDataAdapter(prodCmd);
            prodAdapter.FillSchema(tblProduct, System.Data.SchemaType.Source);

        }

        public static void setupUserAdapter()
        {
            con.ConnectionString = ConStr;
            UserCmd.Connection = con;
            UserCmd.CommandType = System.Data.CommandType.Text;
            UserCmd.CommandText = "Select * from Users order by UserName";
            UserAdapter = new System.Data.SqlClient.SqlDataAdapter(UserCmd);
            UserAdapter.FillSchema(tblProduct, System.Data.SchemaType.Source);
        }

        public static void setupBagAdapter()
        {
            con.ConnectionString = ConStr;
            BagCmd.Connection = con;
            BagCmd.CommandType = System.Data.CommandType.Text;
            BagCmd.CommandText = "Select * from ShoppingBag order by ProductID";
            BagAdapter = new System.Data.SqlClient.SqlDataAdapter(BagCmd);
            BagAdapter.FillSchema(tblProduct, System.Data.SchemaType.Source);
        }
        public static void setupAdapter()
        {
            con.ConnectionString = ConStr;
            prodCmd.Connection = con;
            prodCmd.CommandType = System.Data.CommandType.Text;
            prodCmd.CommandText = "Select * from Product order by ProductID";
            prodAdapter = new System.Data.SqlClient.SqlDataAdapter(prodCmd);
            prodAdapter.FillSchema(tblProduct, System.Data.SchemaType.Source);
            con.ConnectionString = ConStr;
            UserCmd.Connection = con;
            UserCmd.CommandType = System.Data.CommandType.Text;
            UserCmd.CommandText = "Select * from Users order by UserName";
            UserAdapter = new System.Data.SqlClient.SqlDataAdapter(UserCmd);
            UserAdapter.FillSchema(tblProduct, System.Data.SchemaType.Source);
            con.ConnectionString = ConStr;
            BagCmd.Connection = con;
            BagCmd.CommandType = System.Data.CommandType.Text;
            BagCmd.CommandText = "Select * from ShoppingBag order by ProductID";
            BagAdapter = new System.Data.SqlClient.SqlDataAdapter(BagCmd);
            BagAdapter.FillSchema(tblProduct, System.Data.SchemaType.Source);
        }

        public static DataTable NewShoppingBag()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ProductID");
            table.Columns.Add("ProductName");
            table.Columns.Add("Quantity");
            table.Columns.Add("UnitPrice");
            table.Columns.Add("Cost");

            table.PrimaryKey = new DataColumn[] { table.Columns[0] };
            return table;
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
            }
            finally
            {
                con.Close();
            }
        }

        public static void getProduct(string theID, ref int index)
        {
            try
            {

                setupProdAdapter();
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
            //try
            //{
            //   if (!(tblProduct == null))
            //      tblProduct.Clear();

            //   prodCmd.CommandText = "Select * from Product Where ProductID = '" + theID + "'";
            //   prodAdapter.Fill(tblProduct);
            //   index = tblProduct.Rows.Count;
            //}
            //catch (Exception e)
            //{
            //   throw e;
            //}
            //finally
            //{
            //   con.Close();
            //}
        }
        public static void getUsers(string theID, ref int index)
        {
            try
            {
                UserCmd.CommandText = "Select * from Users Where UserName = '" + theID + "'";
                UserAdapter.Fill(tblUsers);
                index = tblUsers.Rows.Count;
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

        public static void UpdateUsers(string theID, string role)
        {
            UserCmd.CommandText = "UPDATE Users SET UserName = @newname, Role = @role Where ProductID = @ID ";
            try
            {
                UserCmd.Parameters.AddWithValue("@newname", theID);
                UserCmd.Parameters.AddWithValue("@role", role);
                con.Open();
                UserCmd.ExecuteNonQuery();
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
        public static void UpdateProduct(string theID, string newName, double newPrice, string newDesc)
        {
            prodCmd.CommandText = "UPDATE Product SET ProductName = @newname, UnitPrice = @Price, Description = @Desc Where ProductID = @ID ";
            try
            {
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

        public static void NewItem(string theID, string newName, double newPrice, int quantity, double Cost)
        {

            try
            {
                string stmt = "INSERT INTO ShoppingBag(ProductID, ProductName, UnitPrice, Quantity, Cost) VALUES (@UProductID, @UProductName, @UUnitPrice, @UQuantity, @UCost)";
                con.Open();
                BagCmd = new System.Data.SqlClient.SqlCommand(stmt, con);
                BagCmd.Parameters.AddWithValue("@UProductID", theID);
                BagCmd.Parameters.AddWithValue("@UProductName", newName);
                BagCmd.Parameters.AddWithValue("@UUnitPrice", newPrice);
                BagCmd.Parameters.AddWithValue("@UQuantity", quantity);
                BagCmd.Parameters.AddWithValue("@UCost", Cost);
                BagCmd.ExecuteNonQuery();
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

