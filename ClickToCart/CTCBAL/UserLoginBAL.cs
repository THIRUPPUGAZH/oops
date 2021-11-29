using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCBE;
using CTCDAL;

namespace CTCBAL
{
  public  class UserLoginBAL
    {
        public UserLoginResponse LoginGet(UserLoginRequest request)
        {
            UserLoginDAL LoginObj = new UserLoginDAL();
            UserLoginResponse response = null;
            try
            {
                response = LoginObj.LoginData(request);
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }
    }
}
