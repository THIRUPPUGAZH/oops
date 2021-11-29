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
    public partial class DisplayCoolings : System.Web.UI.Page
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
            var response = WholeDetail.DisplayCoolings();
            D1.DataSource = response.GetProductData;
            D1.DataBind();
        }
    }
}