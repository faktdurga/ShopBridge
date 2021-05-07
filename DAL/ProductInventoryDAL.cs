using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MODEL;

namespace DAL
{
   public class ProductInventoryDAL
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Suffix { get; set; }
        public string ManufacturerName { get; set; }
        public string ModelNumber { get; set; }
        public string ManufactureDate { get; set; }
        public string ProductCategories { get; set; }
        public string ModelName { get; set; }
        public string CostPerUnit { get; set; }
        public int Quantity { get; set; }
        public string ProductDescription { get; set; }
       

        public int AddInventory(ProductInventoryModel model)
        {
            int res = 0 ;
            try
            {
                string str = @"data source=DESKTOP-93R7Q3C\SQLEXPRESS; initial catalog = ShopBridge;integrated security = true";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("Add_Into_Inventory", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductName",model.ProductName);
                cmd.Parameters.AddWithValue("@Suffix",model.Suffix);
                cmd.Parameters.AddWithValue("@ManufacturerName",model.ManufacturerName);
                cmd.Parameters.AddWithValue("@ModelNumber",model.ModelNumber);
                cmd.Parameters.AddWithValue("@MDate",model.ManufactureDate);
                cmd.Parameters.AddWithValue("@Categories",model.ProductCategories);
                cmd.Parameters.AddWithValue("@MName",model.ModelName);
                cmd.Parameters.AddWithValue("@Cost",model.CostPerUnit);
                cmd.Parameters.AddWithValue("@Quantity",model.Quantity);
                cmd.Parameters.AddWithValue("@PDescription",model.ProductDescription);

                cmd.ExecuteNonQuery();
                res = 1;
            }
            catch (Exception ex)
            {
                res = 0;
            }
            
            return res;
        }

        public DataTable BindByProductID(int ProductID)
        {
            string str = @"data source=DESKTOP-93R7Q3C\SQLEXPRESS; initial catalog = ShopBridge;integrated security = true";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("BindByProductID", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
#pragma warning disable CS0618 // Type or member is obsolete
            cmd.Parameters.Add("ProductID", DbType.Int32).Value = ProductID;
#pragma warning restore CS0618 // Type or member is obsolete
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        public int UpdateInventory(ProductInventoryModel model)
        {
            int res = 0;
            try
            {
                string str = @"data source=DESKTOP-93R7Q3C\SQLEXPRESS; initial catalog = ShopBridge;integrated security = true";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("Update_Into_Inventory", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductID", model.ProductID);
                cmd.Parameters.AddWithValue("@ProductName", model.ProductName);
                cmd.Parameters.AddWithValue("@Suffix", model.Suffix);
                cmd.Parameters.AddWithValue("@ManufacturerName", model.ManufacturerName);
                cmd.Parameters.AddWithValue("@ModelNumber", model.ModelNumber);
                cmd.Parameters.AddWithValue("@MDate", model.ManufactureDate);
                cmd.Parameters.AddWithValue("@Categories", model.ProductCategories);
                cmd.Parameters.AddWithValue("@MName", model.ModelName);
                cmd.Parameters.AddWithValue("@Cost", model.CostPerUnit);
                cmd.Parameters.AddWithValue("@Quantity", model.Quantity);
                cmd.Parameters.AddWithValue("@PDescription", model.ProductDescription);

                cmd.ExecuteNonQuery();
                res = 1;
            }
            catch (Exception ex)
            {
                res = 0;
            }

            return res;

        }

        public int Delete(ProductInventoryModel model)
        {
            int res = 0;
            try
            {
                string str = @"data source=DESKTOP-93R7Q3C\SQLEXPRESS; initial catalog = ShopBridge;integrated security = true";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("Delete_From_Inventory", con);
            
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductID", model.ProductID);
                cmd.ExecuteNonQuery();
                res = 1;

            }
            catch (Exception ex)
            {
                res = 0;
            }
            return res;
        }


    }
}
