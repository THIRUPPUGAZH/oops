﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClickToCart
{
    public partial class AfterAdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CATEGORIES.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Productsload.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Suply.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUserDisplayGridView.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserDisplayGridView.aspx");
        }
    }
}