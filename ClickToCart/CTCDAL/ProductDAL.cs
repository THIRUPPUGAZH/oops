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
 public   class ProductDAL
    {

        public static string ConnectionStr = ConfigurationManager.ConnectionStrings["CTCSHOPPING"].ConnectionString;
        SqlConnection Connect = new SqlConnection(ConnectionStr);


        public ProductResponse AddProduct(ProductRequest request)
        {
            ProductResponse response = new ProductResponse();
            try
            {
                SqlCommand SpCommand = new SqlCommand("AddProduct", Connect);
                SpCommand.CommandType = System.Data.CommandType.StoredProcedure;
                
                SpCommand.Parameters.AddWithValue("@PRODUCT_NAME", request.PRODUCT_NAME);
                SpCommand.Parameters.AddWithValue("@PRODUCT_DESCRIPTION", request.PRODUCT_DESCRIPTION);
                SpCommand.Parameters.AddWithValue("@IMAGE_PATH", request.IMAGE_PATH);
                SpCommand.Parameters.AddWithValue("@UNIT_PRICE", request.UNIT_PRICE);
                SpCommand.Parameters.AddWithValue("@CATEGORY_ID", request.CATEGORY_ID);
                SpCommand.Parameters.AddWithValue("@SUPPLIER_ID", request.SUPPLIER_ID);
                SpCommand.Parameters.AddWithValue("@QUANTITY", request.QUANTITY);


                SpCommand.Parameters.AddWithValue("@Statement", request.Statement);
                SqlParameter StatusParameter = SpCommand.Parameters.Add("@Status", SqlDbType.Int);
                StatusParameter.Direction = ParameterDirection.Output;
                Connect.Open();
                SpCommand.ExecuteNonQuery();
                response.status = Convert.ToInt32(SpCommand.Parameters["@Status"].Value);
            }
            catch(Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }
            return response;




            }
        }
    }

