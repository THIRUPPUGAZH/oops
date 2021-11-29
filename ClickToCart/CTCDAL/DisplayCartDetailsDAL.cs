using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCBE;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CTCDAL
{
    public class DisplayCartDetailsDAL
    {
        public static string ConnectionStr = ConfigurationManager.ConnectionStrings["CTCSHOPPING"].ConnectionString;
        SqlConnection Connect = new SqlConnection(ConnectionStr);
        public DisplayHomeProductRespone DisplayCartDetails(string name)
        {
            DisplayHomeProductRespone response = new DisplayHomeProductRespone();
            try
            {
                SqlCommand cmd = new SqlCommand("DisplayCart", Connect);
                List<DisplayHomeProductRespone> ProductInfo = new List<DisplayHomeProductRespone>();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", name);
                SqlDataReader responsedr;
                Connect.Open();
                responsedr = cmd.ExecuteReader();
                while (responsedr.Read())
                {
                    DisplayHomeProductRespone request1 = new DisplayHomeProductRespone();
                    request1.cart_item_id = (Convert.ToInt32(responsedr["cart_item_id"]));
                    request1.user_name = (responsedr["username"].ToString());
                    request1.PRODUCT_NAME = (responsedr["PRODUCT_NAME"].ToString());
                    request1.date_cart = responsedr["date_cart"].ToString();
                    request1.PRODUCT_ID = Convert.ToInt32((responsedr["product_id"].ToString()));
                    request1.PRODUCT_DESCRIPTION = (responsedr["PRODUCT_DESCRIPTION"].ToString());
                   
                    request1.UNIT_PRICE = Convert.ToInt32((responsedr["UNIT_PRICE"].ToString()));
                    request1.TOTAL_PRICE = Convert.ToInt32((responsedr["TOTAL_PRICE"].ToString()));

                    request1.quantity = (responsedr["quantity"].ToString());
                    ProductInfo.Add(request1);

                }
                response.GetProductData = ProductInfo;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }
}
