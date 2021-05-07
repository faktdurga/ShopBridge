using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Role"].Equals(""))
                {
                    LinkButton7.Visible = false;
                }
                else
                {
                    LinkButton7.Visible = true;
                    LinkButton1.Visible = false;
                    LinkButton3.Visible = true;
                    LinkButton5.Visible = true;
                    LinkButton5.Text = "Hello " + Session["UserID"].ToString();
                }
            }
            catch
            {
                
            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.Aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminSignup.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductInventory.aspx");
        }
    }
}