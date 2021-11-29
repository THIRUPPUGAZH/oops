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
    public partial class Login : System.Web.UI.Page
    {
        UserLoginBAL GetLoginData = new UserLoginBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
            UserLoginRequest request = new UserLoginRequest();
            request.USER_NAME = TextBox1.Text.Trim();
            request.PASSWORD = TextBox2.Text.Trim();
            var response = GetLoginData.LoginGet(request);
            if (Convert.ToInt32(response.status) == 1)
            {
                Response.Write("<script>alert('Login Sucessfully');</script>");
                Session["user"] = request.USER_NAME;
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid Credantials');</script>");

            }
        }
    }
}