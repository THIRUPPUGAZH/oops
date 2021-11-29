using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CTCBAL;
using CTCBE;

namespace ClickToCart
{
    public partial class CATEGORIES : System.Web.UI.Page
    {
        CATEGORIESBAL AddCategoryobj = new CATEGORIESBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CategoriesRequest request = new CategoriesRequest();
            request.CategoryId = Convert.ToInt32 (TextBox1.Text);
            request.CategoryName = TextBox2.Text;
            request.CategoryDescription = TextBox3.Text;
            request.StateMent = "insert";
            var response = AddCategoryobj.AddCatgory(request);
            if (Convert.ToInt32(response.status) == 1)
            {
                Response.Write("<script>alert('Supplier Added Successfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('not added');</script>");
            }
        }
    }
}

