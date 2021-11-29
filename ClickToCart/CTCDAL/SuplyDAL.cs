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
 public   class SuplyDAL
    {
        public static string ConnectionStr = ConfigurationManager.ConnectionStrings["CTCSHOPPING"].ConnectionString;
        SqlConnection Connect = new SqlConnection(ConnectionStr);

        public SuplyResponse AddSupplier(SuplyRequest request)
        {
            SuplyResponse response = new SuplyResponse();
            try
            {
                SqlCommand SpCommand = new SqlCommand("ADDSUPPLIER",Connect);
                SpCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SpCommand.Parameters.AddWithValue("@SUPPLIER_NAME", request.SUPPLIER_NAME);
                SpCommand.Parameters.AddWithValue("@SUPPLIER_GROUP_NAME", request.SUPPLIER_GROUP_NAME);
                SpCommand.Parameters.AddWithValue("@Statement", request.Statement);
                SqlParameter StatusParameter = SpCommand.Parameters.Add("@Status", SqlDbType.Int);
                StatusParameter.Direction = ParameterDirection.Output;
                Connect.Open();
                SpCommand.ExecuteNonQuery();
                response.status = Convert.ToInt32(SpCommand.Parameters["@Status"].Value);

            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }
            return response;

        }
    }
}
