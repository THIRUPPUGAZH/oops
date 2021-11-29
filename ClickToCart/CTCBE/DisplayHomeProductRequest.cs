using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCBE
{
public    class DisplayHomeProductRequest
    {
        public string PRODUCT_ID { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string CATEGORY_ID { get; set; }
        public DateTime date { get; set; }

        public string quantity { get; set; }

        public string user_name { get; set; }
    }
}
