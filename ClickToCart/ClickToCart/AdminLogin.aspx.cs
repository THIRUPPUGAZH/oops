using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClickToCart
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string username = txtuser.Text;
            string password = txtpass.Text;

            if (username == "Thiru" && password == "1234")
            {
                Response.Write("<script>alert('LoginSucessfull')</script>");
                Response.Redirect("AfterAdminLogin.aspx");
            }
            else
            {
                Response.Write("<script>alert('Faild To Login')</script>");

            }
        }

    

    protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}