using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCBE
{
 public   class SuplyRequest
    {
        public int SUPPLIER_ID { get; set; }
        public string SUPPLIER_NAME { get; set; }
        public string SUPPLIER_GROUP_NAME { get; set; }

        public string Statement { get; set; }
    }
}
