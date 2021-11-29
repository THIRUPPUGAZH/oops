using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CTCBE;

namespace CTCDAL
{
    public class ProductDisplay
    {
        public static string ConnectionStr = ConfigurationManager.ConnectionStrings["CTCSHOPPING"].ConnectionString;
        SqlConnection Connect = new SqlConnection(ConnectionStr);
        public ProductDisplayResponse delete(ProductDisplayRequest request)
        {
            
            ProductDisplayResponse response = new ProductDisplayResponse();
            Connect.Open();
            SqlCommand cmd = new SqlCommand("delete from PRODUCT where PRODUCT_ID=@productid ", Connect);
            cmd.Parameters.AddWithValue("@productid", request.id);
            int i = cmd.ExecuteNonQuery();
            return response;

        }
        public ProductDisplayResponse UpdateData(ProductRequest request)
        {
            ProductDisplayResponse response = new ProductDisplayResponse();
            try
            {
                SqlCommand SpCommand = new SqlCommand("EDITDELETE", Connect);
                SpCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SpCommand.Parameters.AddWithValue("@PRODUCT_ID", request.PRODUCT_ID);
                SpCommand.Parameters.AddWithValue("@PRODUCT_NAME", request.PRODUCT_NAME);
                SpCommand.Parameters.AddWithValue("@PRODUCT_DESCRIPTION ", request.PRODUCT_DESCRIPTION);
                SpCommand.Parameters.AddWithValue("@CATEGORY_ID", request.CATEGORY_ID);
                SpCommand.Parameters.AddWithValue("@SUPPLIER_ID", request.SUPPLIER_ID);
                SpCommand.Parameters.AddWithValue("@QUANTITY", request.QUANTITY);
                SpCommand.Parameters.AddWithValue("@Statement","UPDATE");
                Connect.Open();
                SpCommand.ExecuteNonQuery();
                Connect.Close();
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }

}

        
        
       

