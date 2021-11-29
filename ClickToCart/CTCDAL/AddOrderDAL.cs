using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCBE;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net.Mail;

namespace CTCDAL
{
    public class AddOrderDAL
    {

        public static string ConnectionStr = ConfigurationManager.ConnectionStrings["CTCSHOPPING"].ConnectionString;
        SqlConnection Connect = new SqlConnection(ConnectionStr);
        OrderDetailResponse response = new OrderDetailResponse();
        DisplayCartDetailsDAL CartDetails = new DisplayCartDetailsDAL();

        public OrderDetailResponse GetOrder(OrderDetailRequest name)
        {
            String USERNAME = "";
            String MailMessage = "";
            int Total = 0;
            var request1 = CartDetails.DisplayCartDetails(name.user_name);
            var user_data = request1.GetProductData;


            try
            {
                foreach (var row in user_data)
                {
                    USERNAME = row.user_name;
                    MailMessage += "YOUR ORDERED PRODUCT: " + row.PRODUCT_NAME + ", SELECTED QUANTITY: " + row.quantity + ", TOTAL AMOUNT: " + row.TOTAL_PRICE + "\n<br>";
                    Total += Convert.ToInt32(row.TOTAL_PRICE);

                    SqlCommand SpCommand = new SqlCommand("PLACEORDER", Connect);
                    SpCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SpCommand.Parameters.AddWithValue("@PRODUCT_ID", row.PRODUCT_ID);
                    SpCommand.Parameters.AddWithValue("@USERNAME", name.user_name.ToString());
                    SpCommand.Parameters.AddWithValue("@TOTAL_PRICE", row.TOTAL_PRICE);
                    SpCommand.Parameters.AddWithValue("@DATE_OF_ORDER", row.date_cart.ToString());
                    SpCommand.Parameters.AddWithValue("@SELECTED_QUANTITY", row.quantity);
                   
                    Connect.Open();
                    SpCommand.ExecuteNonQuery();
                    Connect.Close();

                    SqlCommand cmd1 = new SqlCommand("GetEmail", Connect);
                    cmd1.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd1.Parameters.AddWithValue("@USER_NAME", USERNAME);
                    Connect.Open();
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    reader1.Read();
                    string ToMail = reader1["EMAIL_ID"].ToString();
                    Connect.Close();

                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("thiruppugazh82@gmail.com");
                    msg.To.Add(ToMail);
                    msg.Subject = "Confirmation Email For Successfully Placed Order!!";
                    msg.Body = MailMessage + "\n<br>" + "TOTAL AMOUNT =" + Total + "\n<br>" + "YOUR ORDER DATE" + DateTime.Now + "\n<br>" + "WITHIN TWO DAYS YOU WILL GET YOUR PRODUCT. THANK YOU FOR SHOPPING WITH US!! ";
                    msg.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential ntc = new System.Net.NetworkCredential();
                    // https://www.google.com/settings/security/lesssecureapps
                    ntc.UserName = "thiruppugazh82@gmail.com";
                    ntc.Password = "Thiruppugazh@123";
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = ntc;
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Send(msg);

                    ///this is for redirect  to .cs file  email sending or not check ViewCartDetails ///
                    response.status = 1;

                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }
}

               






