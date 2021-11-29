using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCBE;
using CTCDAL;

namespace CTCBAL
{
  public  class SuplyBAL
    {
        public SuplyResponse AddSupplier(SuplyRequest request)
        {
            SuplyDAL AddSuplierDALObj = new SuplyDAL();
            SuplyResponse response = null;
            try
            {
                response = AddSuplierDALObj.AddSupplier(request);
            }
            catch (Exception)
            {
                throw;
            }
            return response;

        }
    }
}
