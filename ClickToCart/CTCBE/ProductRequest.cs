using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCBE
{
 public   class ProductRequest
    {
        public int PRODUCT_ID { get; set; }
        public string PRODUCT_NAME { get; set; }

        public string PRODUCT_DESCRIPTION { get; set; }

        public string IMAGE_PATH { get; set; }
        public int UNIT_PRICE { get; set; }
        public string CATEGORY_ID { get; set; }
        public string SUPPLIER_ID { get; set; }
        public string QUANTITY { get; set; }

        public string Statement { get; set; }
    }
}
