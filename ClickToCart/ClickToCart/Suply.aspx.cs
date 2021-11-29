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
    public partial class Suply : System.Web.UI.Page
    {
        SuplyBAL AddSupplierobj = new SuplyBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SuplyRequest request = new SuplyRequest();
            request.SUPPLIER_ID = Convert.ToInt32(TextBox1.Text);
            request.SUPPLIER_NAME = TextBox2.Text;
            request.SUPPLIER_GROUP_NAME = TextBox3.Text;
            request.Statement = "insert";
            var response = AddSupplierobj.AddSupplier(request);
            if (Convert.ToInt32(response.status) == 1)
            {
                Response.Write("<script>alert('Supplier Added Successfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('not added');</script>");
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
