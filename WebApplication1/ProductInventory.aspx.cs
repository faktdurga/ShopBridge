using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODEL;
using BAL;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class ProductInventory : System.Web.UI.Page
    {
        ProductInventoryModel model = new ProductInventoryModel();
        ProductInventoryBAL bal = new ProductInventoryBAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateGrid();

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            model.ProductName = txtProductName.Text;
            model.Suffix = txtSuffix.Text;
            model.ManufacturerName = txtManufacturer.Text;
            model.ModelNumber = txtModel.Text;
            model.ManufactureDate = txtMDate.Text;
            model.ProductCategories = lstProductCategories.SelectedValue.ToString();
            model.ModelName = txtModelName.Text;
            model.CostPerUnit = txtProductCost.Text;
            model.Quantity = Convert.ToInt32(txtQuantity.Text);
            model.ProductDescription = txtAddress.Text;


            int res = bal.AddInventory(model);

            if (res > 0)
            {
                Response.Write("<script> alert('Record saved successfully')</script>");
            }
            else
            {
                Response.Write("<script> alert('Error')</script>");
            }
        }

         public void PopulateGrid()
        {
            DataTable dt = new DataTable();
            string str = @"data source=DESKTOP-93R7Q3C\SQLEXPRESS; initial catalog = ShopBridge;integrated security = true";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ProductID, ProductName, Suffix, ModelName, ProductCost, ProductQuantity FROM Inventory", con);
            da.Fill(dt);

            grdProductList.DataSource = dt;
            grdProductList.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            model.ProductID = Convert.ToInt32(txtProductID.Text);
            model.ProductName = txtProductName.Text;
            model.Suffix = txtSuffix.Text;
            model.ManufacturerName = txtManufacturer.Text;
            model.ModelNumber = txtModel.Text;
            model.ManufactureDate = txtMDate.Text;
            model.ProductCategories = lstProductCategories.SelectedValue.ToString();
            model.ModelName = txtModelName.Text;
            model.CostPerUnit = txtProductCost.Text;
            model.Quantity = Convert.ToInt32(txtQuantity.Text);
            model.ProductDescription = txtAddress.Text;


            int res = bal.UpdateInventory(model);

            if (res > 0)
            {
                Response.Write("<script> alert('Record saved successfully')</script>");
            }
            else
            {
                Response.Write("<script> alert('Error')</script>");
            }

        }



        protected void btnGO_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int ProductID = Convert.ToInt32(txtProductID.Text);
            dt = bal.BindByProductID(ProductID);

            txtProductName.Text = dt.Rows[0]["ProductName"].ToString();
            txtSuffix.Text = dt.Rows[0]["Suffix"].ToString();
            txtManufacturer.Text = dt.Rows[0]["ManufacturerName"].ToString();
            txtModel.Text = dt.Rows[0]["ModelNumber"].ToString();
            txtMDate.Text = dt.Rows[0]["ManufacturerDate"].ToString();
            txtModelName.Text = dt.Rows[0]["ModelName"].ToString();
            txtProductCost.Text = dt.Rows[0]["ProductCost"].ToString();
            txtQuantity.Text = dt.Rows[0]["ProductQuantity"].ToString();
            txtAddress.Text = dt.Rows[0]["ProductDescription"].ToString();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            model.ProductID = Convert.ToInt32(txtProductID.Text);
            int res = bal.Delete(model);

            if (res == 1)
            {
                Response.Write("<script> alert('Record deleted successfully')</script>");
            }
            else
            {
                Response.Write("<script> alert('Error')</script>");
            }
        }
    }
}