using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCBE
{
 public   class OrderDetailRequest
    {
        public int PRODUCT_ID { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string user_name { get; set; }

        public string quantity { get; set; }

        public int UNIT_PRICE { get; set; }
        public int TOTAL_PRICE { get; set; }

        public string date_cart { get; set; }
        



    }
}
