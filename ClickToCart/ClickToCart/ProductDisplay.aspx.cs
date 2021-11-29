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
    public partial class ProductDisplay : System.Web.UI.Page
    {
        DisplayHomeProductBAL WholeDetail = new DisplayHomeProductBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataFill();
            }

        }
        public void DataFill()
        {
            var response = WholeDetail.DisplayProduct();
            D1.DataSource = response.GetProductData;
            D1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var response = WholeDetail.DisplayCrackers();
            D1.DataSource = response.GetProductData;
            D1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var response = WholeDetail.DisplayCoolings();
            D1.DataSource = response.GetProductData;
            D1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var response = WholeDetail.DisplayStationary();
            D1.DataSource = response.GetProductData;
            D1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            var response = WholeDetail.DisplayMask();
            D1.DataSource = response.GetProductData;
            D1.DataBind();
        }

        protected void ProductSingleView(object sender,DataListCommandEventArgs e)
        {
            if (e.CommandName == "ViewProduct")
            {
                Response.Redirect("ProductSingleView.aspx?pID=" + e.CommandArgument.ToString());
            }
        }

        protected void D1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                DisplayHomeProductRequest obj = new DisplayHomeProductRequest();
                obj.date = DateTime.Now;
                obj.quantity = 1.ToString();
                int id = Convert.ToInt32((sender as LinkButton).CommandArgument);
                obj.PRODUCT_ID = id.ToString();
                obj.user_name = Session["user"].ToString();
                var response = WholeDetail.cartshow(obj);

            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
            



        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCartDetails.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}