using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCBE;
using CTCDAL;

namespace CTCBAL
{
    public class OrderDetailBAL
    {
        string Alert = "";
        public string GetOrder(OrderDetailRequest name)
        {
            AddOrderDAL ObjGet = new AddOrderDAL();
            try
            {
                var response = ObjGet.GetOrder(name);
               // Alert = "Order Successfully placed";
            }
            catch (Exception)
            {
               // Alert = "Please ";
            }
            return Alert;
        }
    }

}


            
        
        

    
       