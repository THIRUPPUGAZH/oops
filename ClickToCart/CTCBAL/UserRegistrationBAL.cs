using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCBE;
using CTCDAL;

namespace CTCBAL
{
 public   class UserRegistrationBAL
    {
        public RegisterResponse UserRegister (RegisterRequest request)
        {
            RegisterDAL CustomerRegisterObj = new RegisterDAL();
            RegisterResponse response = null;
            try
            {
                response = CustomerRegisterObj.UserRegisterSave(request);
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }
    }
}
