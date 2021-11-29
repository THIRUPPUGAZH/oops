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
    public partial class Register : System.Web.UI.Page
    {
        UserRegistrationBAL UserRegister = new UserRegistrationBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNSUBMIT_Click(object sender, EventArgs e)
        {
            RegisterRequest request = new RegisterRequest();
            request.USER_NAME = TextBox1.Text.Trim();
            request.FIRST_NAME = TextBox2.Text.Trim();
            request.LAST_NAME = TextBox3.Text.Trim();
            request.DATEOFBIRTH = TextBox11.Text.Trim();
            request.EMAIL_ID = TextBox14.Text.Trim();
            request.CONTACT_NUMBER = TextBox5.Text.Trim();
            request.ADDRESS = TextBox6.Text.Trim();
            request.CITY = TextBox7.Text.Trim();
            request.ZIP = TextBox8.Text.Trim();
            request.COUNTRY = TextBox9.Text.Trim();
            request.PASSWORD = TextBox12.Text.Trim();
            request.Statement = "insert";
            var response = UserRegister.UserRegister(request);
            if (Convert.ToInt32(response.status) == 1)
            {
                Response.Write("<script>alert('Registration sucessfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('Registration not sucessfull');</script>");
            }
        }
    }
}

        