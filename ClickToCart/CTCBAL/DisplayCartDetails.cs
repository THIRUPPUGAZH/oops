using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCBE;
using CTCDAL;

namespace CTCBAL
{
 public   class DisplayCartDetails
    {
        public DisplayHomeProductRespone DisplayCartDetail(string name)
        {
            DisplayCartDetailsDAL GetALLProduct = new DisplayCartDetailsDAL();
            DisplayHomeProductRespone response = null;
            try
            {
                response = GetALLProduct.DisplayCartDetails(name);
            }
            catch (Exception ex)
            {
                var MSG = ex.Message;
            }
            return response;
        }
    }
}

