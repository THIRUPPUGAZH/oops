using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCBE
{
 public   class DisplayHomeProductRespone:BaseResponse
    {
        public List<DisplayHomeProductRespone> GetProductData = new List<DisplayHomeProductRespone>();

        public int cart_item_id { get; set; }
        public  int PRODUCT_ID { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string PRODUCT_DESCRIPTION { get; set; }
        public string IMAGE_PATH { get; set; }
        public int UNIT_PRICE { get; set; }
        public int CATEGORY_ID { get; set; }
        public int SUPPLIER_ID { get; set; }
        public string  QUANTITY { get; set; }

        public string user_name { get; set; }

        public string date_cart{ get; set; }
        public int TOTAL_PRICE { get; set; }

        public string quantity { get; set; }
        public int USERID { get; set; }

    }
}
