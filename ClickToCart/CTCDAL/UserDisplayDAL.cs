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
public    class UserDisplayDAL
    {
        public static string ConnectionStr = ConfigurationManager.ConnectionStrings["CTCSHOPPING"].ConnectionString;
        SqlConnection Connect = new SqlConnection(ConnectionStr);

        public UserDisplayResponseBE delete(UserDisplayRequestBE request)
        {
            UserDisplayResponseBE response = new UserDisplayResponseBE();
            Connect.Open();
            SqlCommand cmd = new SqlCommand("delete from REGISTRATION_DETAILS where USERID=@USERID ", Connect);
            cmd.Parameters.AddWithValue("@USERID", request.id);
            int i = cmd.ExecuteNonQuery();
            return response;
        }
        public UserDisplayResponseBE UpdateData(RegisterRequest request)
        {
            UserDisplayResponseBE response = new UserDisplayResponseBE();
            try
            {
                SqlCommand SpCommand = new SqlCommand("USERDISPLAY", Connect);
                SpCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SpCommand.Parameters.AddWithValue("@USERID", request.USERID);
                SpCommand.Parameters.AddWithValue("@USER_NAME", request.USER_NAME);
                SpCommand.Parameters.AddWithValue("@FIRST_NAME", request.FIRST_NAME);
                SpCommand.Parameters.AddWithValue("@LAST_NAME", request.LAST_NAME);
                SpCommand.Parameters.AddWithValue("@CONTACT_NUMBER", request.CONTACT_NUMBER);
                SpCommand.Parameters.AddWithValue("@ADDRESS", request.ADDRESS);
                SpCommand.Parameters.AddWithValue("@CITY", request.CITY);
                SpCommand.Parameters.AddWithValue("@ZIP", request.ZIP);
                SpCommand.Parameters.AddWithValue("@COUNTRY", request.COUNTRY);
                SpCommand.Parameters.AddWithValue("@EMAIL_ID", request.EMAIL_ID);
                SpCommand.Parameters.AddWithValue("@PASSWORD", request.PASSWORD);
                SpCommand.Parameters.AddWithValue("@Statement", "UPDATE");
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
