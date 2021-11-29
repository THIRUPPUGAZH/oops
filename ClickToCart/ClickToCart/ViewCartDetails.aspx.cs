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
    public partial class ViewCartDetails : System.Web.UI.Page
    {

        DisplayCartDetails WholeDetail = new DisplayCartDetails();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    DataFill(Session["user"].ToString());
                }
            }

        }
        public void DataFill(string name)

        {
            var response = WholeDetail.DisplayCartDetail(name);
            grid.DataSource = response.GetProductData;
            grid.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grid.EditIndex = -1;
            DataFill(Session["User"].ToString());
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DisplayHomeProductBAL ObjDelete = new DisplayHomeProductBAL();
            int id = Convert.ToInt32(grid.DataKeys[e.RowIndex].Values["cart_item_id"]);
            ObjDelete.deleteCart(id);

            Response.Redirect("ViewCartDetails.aspx");

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grid.EditIndex = e.NewEditIndex;
            DataFill(Session["user"].ToString());

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            CartAdd request = new CartAdd();
            DisplayHomeProductBAL ObjUpdate = new DisplayHomeProductBAL();
            int id = Convert.ToInt16(grid.DataKeys[e.RowIndex].Values["cart_item_id"].ToString());
            DropDownList ddlSelectQuantity = grid.Rows[e.RowIndex].FindControl("ddlSelectQuantity") as DropDownList;

            request.id = id;
            request.quantity = Convert.ToInt32(ddlSelectQuantity.SelectedItem.Text);
            ObjUpdate.updatecart(request);
            grid.EditIndex = -1;
            DataFill(Session["user"].ToString());



        }
        protected void Order_Click(object sender, EventArgs e)
        {
            BaseResponse response1 = new BaseResponse();
            OrderDetailRequest GetUserName = new OrderDetailRequest();
            OrderDetailBAL OrderUser = new OrderDetailBAL();
            GetUserName.user_name = Session["user"].ToString();
            string response = OrderUser.GetOrder(GetUserName);
            

            string message = "Order Placed Successfully Check Your Email THANK YOU!! Keep Shopping!!!";
            string url = "ProductDisplay.aspx";

            string script = "window.onload = function(){ alert('";
            script += message;
            script += "');";
            script += "window.location = '";
            script += url;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductDisplay.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}




