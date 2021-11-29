using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCBE
{
    public class ProductDisplayResponse : BaseResponse
    {
        public List<ProductRequest> ProductDetails{get; set;}
        public string Statement { get; set; }


    }
}
