using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CTCBAL;
namespace ClickToCart
{
    public partial class ProductSingleView : System.Web.UI.Page
    {
        DisplayHomeProductBAL WholeDetail = new DisplayHomeProductBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["pID"].ToString());
                DataFill(id);
            }

        }
        public void DataFill(int id)
        {
            var response = WholeDetail.GetFilter(id);
            D1.DataSource = response.GetProductData;
            D1.DataBind();
        }

        protected void D1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}