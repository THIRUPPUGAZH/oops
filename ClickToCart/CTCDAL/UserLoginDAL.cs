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
 public   class UserLoginDAL
    {
        public static string ConnectionStr = ConfigurationManager.ConnectionStrings["CTCSHOPPING"].ConnectionString;
        SqlConnection Connect = new SqlConnection(ConnectionStr);

        public UserLoginResponse LoginData(UserLoginRequest request)
        {
            UserLoginResponse response = new UserLoginResponse();
            try
            {
                SqlCommand Spcommand = new SqlCommand("UserLogin", Connect);
                Spcommand.CommandType = System.Data.CommandType.StoredProcedure;
                Spcommand.Parameters.AddWithValue("@USER_NAME", request.USER_NAME);
                Spcommand.Parameters.AddWithValue("@PASSWORD", request.PASSWORD);
                SqlParameter StatusParameter = Spcommand.Parameters.Add("@Invalid", SqlDbType.Int);
                StatusParameter.Direction = ParameterDirection.Output;
                Connect.Open();
                Spcommand.ExecuteNonQuery();
                response.status = (int)Spcommand.Parameters["@Invalid"].Value;
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }
}
