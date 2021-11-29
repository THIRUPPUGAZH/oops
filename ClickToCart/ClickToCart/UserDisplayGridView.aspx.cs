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
    public partial class UserDisplayGridView : System.Web.UI.Page
    {
        ProductDisplayBAL GetProductObj = new ProductDisplayBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

            
            

        }
        protected void refereshdata()
        {

            Response.Redirect("~/UserDisplayGridView.aspx");

        }


        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        { 

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ProductDisplayRequest request = new ProductDisplayRequest();
            request.id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["PRODUCT_ID"]);
            var response = GetProductObj.delete(request);
            refereshdata();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            ProductRequest request = new ProductRequest();
            request.Statement = "UPDATE";
            request.PRODUCT_ID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["PRODUCT_ID"]);
            TextBox txtPRODUCT_NAME = GridView1.Rows[e.RowIndex].FindControl("PRODUCT_NAME") as TextBox;
            TextBox txtPRODUCT_DESCRIPTION = GridView1.Rows[e.RowIndex].FindControl("PRODUCT_DESCRIPTION") as TextBox;
            TextBox txtCATEGORY_ID = GridView1.Rows[e.RowIndex].FindControl("CATEGORY_ID") as TextBox;
            TextBox txtSUPPLIER_ID = GridView1.Rows[e.RowIndex].FindControl("SUPPLIER_ID") as TextBox;
            TextBox txtQUANTITY = GridView1.Rows[e.RowIndex].FindControl("QUANTITY") as TextBox;

            request.PRODUCT_NAME = txtPRODUCT_NAME.Text;
            request.PRODUCT_DESCRIPTION = txtPRODUCT_DESCRIPTION.Text;
            request.CATEGORY_ID = txtCATEGORY_ID.Text;
            request.SUPPLIER_ID = txtSUPPLIER_ID.Text;
            request.QUANTITY = txtQUANTITY.Text;

            var response = GetProductObj.UpdateData(request);
            refereshdata();



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AfterAdminLogin.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}