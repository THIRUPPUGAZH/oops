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
    public    class CategoriesDAL
    {
        public static string ConnectionStr = ConfigurationManager.ConnectionStrings["CTCSHOPPING"].ConnectionString;
        SqlConnection Connect = new SqlConnection(ConnectionStr);

        public CategoriesResponse AddCatgory(CategoriesRequest request)
        {
            CategoriesResponse response = new CategoriesResponse();
            try
            {
                SqlCommand Spcommand = new SqlCommand("ADDCATEGORIES", Connect);
                Spcommand.CommandType = System.Data.CommandType.StoredProcedure;
                
                Spcommand.Parameters.AddWithValue("@CATEGORY_NAME", request.CategoryName);
                Spcommand.Parameters.AddWithValue("@CATEGORY_DESCRIPTION", request.CategoryDescription);
                Spcommand.Parameters.AddWithValue("@Statement", request.StateMent);
                SqlParameter StatusParameter = Spcommand.Parameters.Add("@Status", SqlDbType.Int);
                StatusParameter.Direction = ParameterDirection.Output;
                Connect.Open();
                Spcommand.ExecuteNonQuery();
                response.status = Convert.ToInt32(Spcommand.Parameters["@Status"].Value);
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

    }
}

