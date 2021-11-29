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
    public class HomeProductDAL
    {
        public static string ConnectionStr = ConfigurationManager.ConnectionStrings["CTCSHOPPING"].ConnectionString;
        SqlConnection Connect = new SqlConnection(ConnectionStr);

        public DisplayHomeProductRespone DisplayProduct()
        {
            DisplayHomeProductRespone response = new DisplayHomeProductRespone();
            try
            {
                SqlCommand cmd = new SqlCommand("DisplayAllProduct", Connect);
                List<DisplayHomeProductRespone> ProductInfo = new List<DisplayHomeProductRespone>();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader responsedr;
                Connect.Open();
                responsedr = cmd.ExecuteReader();
                while (responsedr.Read())
                {
                    DisplayHomeProductRespone request1 = new DisplayHomeProductRespone();
                    request1.PRODUCT_ID = Convert.ToInt32((responsedr["PRODUCT_ID"].ToString()));
                    request1.PRODUCT_NAME = (responsedr["PRODUCT_NAME"].ToString());
                    request1.PRODUCT_DESCRIPTION = (responsedr["PRODUCT_DESCRIPTION"].ToString());
                    request1.IMAGE_PATH = (responsedr["IMAGE_PATH"].ToString());
                    request1.UNIT_PRICE = Convert.ToInt32((responsedr["UNIT_PRICE"].ToString()));

                    request1.QUANTITY = (responsedr["QUANTITY"].ToString());
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
        public DisplayHomeProductRespone DisplayCoolings()
        {
            DisplayHomeProductRespone response = new DisplayHomeProductRespone();
            try
            {
                SqlCommand cmd = new SqlCommand("DisplayViewCooling", Connect);
                List<DisplayHomeProductRespone> ProductInfo = new List<DisplayHomeProductRespone>();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader responsedr;
                Connect.Open();
                responsedr = cmd.ExecuteReader();
                while (responsedr.Read())
                {
                    DisplayHomeProductRespone request1 = new DisplayHomeProductRespone();
                    request1.PRODUCT_ID = Convert.ToInt32((responsedr["PRODUCT_ID"].ToString()));
                    request1.PRODUCT_NAME = (responsedr["PRODUCT_NAME"].ToString());
                    request1.PRODUCT_DESCRIPTION = (responsedr["PRODUCT_DESCRIPTION"].ToString());
                    request1.IMAGE_PATH = (responsedr["IMAGE_PATH"].ToString());
                    request1.UNIT_PRICE = Convert.ToInt32((responsedr["UNIT_PRICE"].ToString()));

                    request1.QUANTITY = (responsedr["QUANTITY"].ToString());
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
        public DisplayHomeProductRespone DisplayCrackers()
        {
            DisplayHomeProductRespone response = new DisplayHomeProductRespone();
            try
            {
                SqlCommand cmd = new SqlCommand("DisplayViewCrackers", Connect);
                List<DisplayHomeProductRespone> ProductInfo = new List<DisplayHomeProductRespone>();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader responsedr;
                Connect.Open();
                responsedr = cmd.ExecuteReader();
                while (responsedr.Read())
                {
                    DisplayHomeProductRespone request1 = new DisplayHomeProductRespone();
                    request1.PRODUCT_ID = Convert.ToInt32((responsedr["PRODUCT_ID"].ToString()));
                    request1.PRODUCT_NAME = (responsedr["PRODUCT_NAME"].ToString());
                    request1.PRODUCT_DESCRIPTION = (responsedr["PRODUCT_DESCRIPTION"].ToString());
                    request1.IMAGE_PATH = (responsedr["IMAGE_PATH"].ToString());
                    request1.UNIT_PRICE = Convert.ToInt32((responsedr["UNIT_PRICE"].ToString()));

                    request1.QUANTITY = (responsedr["QUANTITY"].ToString());
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
        public DisplayHomeProductRespone DisplayMask()
        {
            DisplayHomeProductRespone response = new DisplayHomeProductRespone();
            try
            {
                SqlCommand cmd = new SqlCommand("DisplayviewMask", Connect);
                List<DisplayHomeProductRespone> ProductInfo = new List<DisplayHomeProductRespone>();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader responsedr;
                Connect.Open();
                responsedr = cmd.ExecuteReader();
                while (responsedr.Read())
                {
                    DisplayHomeProductRespone request1 = new DisplayHomeProductRespone();
                    request1.PRODUCT_ID = Convert.ToInt32((responsedr["PRODUCT_ID"].ToString()));
                    request1.PRODUCT_NAME = (responsedr["PRODUCT_NAME"].ToString());
                    request1.PRODUCT_DESCRIPTION = (responsedr["PRODUCT_DESCRIPTION"].ToString());
                    request1.IMAGE_PATH = (responsedr["IMAGE_PATH"].ToString());
                    request1.UNIT_PRICE = Convert.ToInt32((responsedr["UNIT_PRICE"].ToString()));

                    request1.QUANTITY = (responsedr["QUANTITY"].ToString());
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
        public DisplayHomeProductRespone DisplayStationary()
        {
            DisplayHomeProductRespone response = new DisplayHomeProductRespone();
            try
            {
                SqlCommand cmd = new SqlCommand("DisplayViewStationary", Connect);
                List<DisplayHomeProductRespone> ProductInfo = new List<DisplayHomeProductRespone>();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader responsedr;
                Connect.Open();
                responsedr = cmd.ExecuteReader();
                while (responsedr.Read())
                {
                    DisplayHomeProductRespone request1 = new DisplayHomeProductRespone();
                    request1.PRODUCT_ID = Convert.ToInt32((responsedr["PRODUCT_ID"].ToString()));
                    request1.PRODUCT_NAME = (responsedr["PRODUCT_NAME"].ToString());
                    request1.PRODUCT_DESCRIPTION = (responsedr["PRODUCT_DESCRIPTION"].ToString());
                    request1.IMAGE_PATH = (responsedr["IMAGE_PATH"].ToString());
                    request1.UNIT_PRICE = Convert.ToInt32((responsedr["UNIT_PRICE"].ToString()));

                    request1.QUANTITY = (responsedr["QUANTITY"].ToString());
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
        public DisplayHomeProductRespone GetFilter(int id)
        {
            DisplayHomeProductRespone response = new DisplayHomeProductRespone();
            try
            {
                SqlCommand cmd = new SqlCommand("GetFilterData", Connect);
                List<DisplayHomeProductRespone> ProductInfo = new List<DisplayHomeProductRespone>();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader responsedr;
                Connect.Open();
                responsedr = cmd.ExecuteReader();
                while (responsedr.Read())
                {
                    DisplayHomeProductRespone request1 = new DisplayHomeProductRespone();
                    request1.PRODUCT_ID = Convert.ToInt32((responsedr["PRODUCT_ID"].ToString()));
                    request1.PRODUCT_NAME = (responsedr["PRODUCT_NAME"].ToString());
                    request1.PRODUCT_DESCRIPTION = (responsedr["PRODUCT_DESCRIPTION"].ToString());
                    request1.IMAGE_PATH = (responsedr["IMAGE_PATH"].ToString());
                    request1.UNIT_PRICE = Convert.ToInt32((responsedr["UNIT_PRICE"].ToString()));

                    request1.QUANTITY = (responsedr["QUANTITY"].ToString());
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

        public DisplayHomeProductRespone cartshow(DisplayHomeProductRequest request)
        {
            DisplayHomeProductRespone response = new DisplayHomeProductRespone();
            try
            {
                SqlCommand Spcommand = new SqlCommand("proccart", Connect);
                Spcommand.CommandType = System.Data.CommandType.StoredProcedure;
                Spcommand.Parameters.AddWithValue("@username", request.user_name);
                Spcommand.Parameters.AddWithValue("@quantity", request.quantity);
                Spcommand.Parameters.AddWithValue("@date", request.date.ToString());
                Spcommand.Parameters.AddWithValue("@product_id", Convert.ToInt32(request.PRODUCT_ID));

                Connect.Open();
                Spcommand.ExecuteNonQuery();
                Connect.Close();
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public void UpdateCart(CartAdd request)
        {
            SqlCommand Spcommand = new SqlCommand("UpdateCart", Connect);
            Spcommand.CommandType = System.Data.CommandType.StoredProcedure;
            Spcommand.Parameters.AddWithValue("@id", request.id);
            Spcommand.Parameters.AddWithValue("@quantity", request.quantity);
            Connect.Open();
            Spcommand.ExecuteNonQuery();
            Connect.Close();


        }


        public void DeleteCart(int id)
        {

            SqlCommand Spcommand = new SqlCommand("DeleteCart", Connect);
            Spcommand.CommandType = System.Data.CommandType.StoredProcedure;
            Spcommand.Parameters.AddWithValue("@id",id);
            Connect.Open();
            Spcommand.ExecuteNonQuery();
            Connect.Close();
        }
    }
}

