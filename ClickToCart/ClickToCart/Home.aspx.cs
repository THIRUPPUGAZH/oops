using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CTCBE;
using CTCBAL;

namespace ClickToCart
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        DisplayHomeProductBAL Displayornot = new DisplayHomeProductBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"]!=null)
            {
                Label1.Text = "Welcome!" + Session["user"];
                btnLogout.Visible = true;
                LinkButton4.Visible = false;
                LinkButton5.Visible = false;
            }
            else
            {
                LinkButton4.Visible = true;
                LinkButton5.Visible = true;
                btnLogout.Visible = false;
            }

        }

        protected void product_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductDisplay.aspx");
        }

        protected void Loing_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
          
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        { 
            if (Session ["user"] != null)
            {
              
                Response.Redirect("ProductDisplay.aspx");
            }
            else
            {
                Response.Write("<script>alert('Hello!!! user you have to Login first');</script>");
            }

            
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            LinkButton4.Visible = true;
            LinkButton5.Visible = true;
            btnLogout.Visible = false;
        }
    }
}