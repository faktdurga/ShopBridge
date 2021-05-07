using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace WebApplication1
{
    public partial class AdminLogin : System.Web.UI.Page
    {
    

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            string str = @"data source=DESKTOP-93R7Q3C\SQLEXPRESS; initial catalog = ShopBridge;integrated security = true";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("AdminLogin", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("UserID", txtUserID.Text);
            cmd.Parameters.AddWithValue("PWD", txtPwd.Text);
            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Response.Write("<script> alert('Log in Successfull')</script>");
                    Session["UserID"] = dr.GetValue(1).ToString();
                    Session["Role"] = "Admin";
                }
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("<script> alert('Invalid Credentials')</script>");
            }

            
        }
    }
}