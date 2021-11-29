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
  public  class RegisterDAL
    {
        public static string ConnectionStr = ConfigurationManager.ConnectionStrings["CTCSHOPPING"].ConnectionString;
        SqlConnection Connect = new SqlConnection(ConnectionStr);

        public RegisterResponse UserRegisterSave (RegisterRequest request)
        {
            RegisterResponse response = new RegisterResponse();
            try
            {
                SqlCommand Spcommand = new SqlCommand("UserRegister", Connect);
                Spcommand.CommandType = System.Data.CommandType.StoredProcedure;
                Spcommand.Parameters.AddWithValue("@USER_NAME", request.USER_NAME);
                Spcommand.Parameters.AddWithValue("@FIRST_NAME", request.FIRST_NAME);
                Spcommand.Parameters.AddWithValue("@LAST_NAME", request.LAST_NAME);
                Spcommand.Parameters.AddWithValue("@CONTACT_NUMBER", request.CONTACT_NUMBER);
                Spcommand.Parameters.AddWithValue("@ADDRESS", request.ADDRESS);
                Spcommand.Parameters.AddWithValue("@CITY", request.CITY);
                Spcommand.Parameters.AddWithValue("@ZIP", request.ZIP);
                Spcommand.Parameters.AddWithValue("@COUNTRY", request.COUNTRY);
                Spcommand.Parameters.AddWithValue("@EMAIL_ID", request.EMAIL_ID);
                Spcommand.Parameters.AddWithValue("@DATEOFBIRTH", request.DATEOFBIRTH);
                Spcommand.Parameters.AddWithValue("@PASSWORD", request.PASSWORD);
                Spcommand.Parameters.AddWithValue("@Statement", request.Statement);
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
