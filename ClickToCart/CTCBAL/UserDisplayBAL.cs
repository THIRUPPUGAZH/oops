using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCBE;
using CTCDAL;

namespace CTCBAL
{
 public   class UserDisplayBAL
    {
        public UserDisplayResponseBE delete(UserDisplayRequestBE request)
        {
           UserDisplayResponseBE response = null;
            UserDisplayDAL objUserDetails = new UserDisplayDAL();

            response = objUserDetails.delete(request);
            return response;

        }
        public UserDisplayResponseBE UpdateDatas(RegisterRequest request)
        {
           UserDisplayResponseBE response = null;
            UserDisplayDAL GetDataDal = new UserDisplayDAL();
            response = GetDataDal.UpdateData(request);
            return response;
        }
    }
}

    

