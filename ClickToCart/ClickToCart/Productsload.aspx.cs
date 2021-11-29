using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CTCBE;
using CTCBAL;
using System.IO;
using System.Drawing;

namespace ClickToCart
{
    public partial class Productsload : System.Web.UI.Page
    {
        ProductBAL addproductobj = new ProductBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ProductRequest request = new ProductRequest();
            request.PRODUCT_ID = Convert.ToInt32(TextBox1.Text);
            request.PRODUCT_NAME = TextBox2.Text;
            request.PRODUCT_DESCRIPTION = TextBox3.Text;
            string filename = Path.GetFileName(imagepath.FileName);
            imagepath.SaveAs(Server.MapPath("~/" + filename));
            request.IMAGE_PATH = filename;
            request.UNIT_PRICE = Convert.ToInt32(TextBox5.Text);
            request.CATEGORY_ID = DropDownList3.SelectedValue.ToString();
            request.SUPPLIER_ID = DropDownList2.SelectedValue.ToString();
            request.QUANTITY = TextBox8.Text;
            request.Statement = "insert";
            var response = addproductobj.AddProduct(request);
            if (Convert.ToInt32(response.status) == 1)
            {
                Response.Write("<script>alert('product added succesfully');</script>");


            }
            else
            {
                Response.Write("<script>alert('Failed');</script>");
            }




        }
    }
}