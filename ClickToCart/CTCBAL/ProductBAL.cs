using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCBE;
using CTCDAL;

namespace CTCBAL
{
 public   class ProductBAL
    {
        public ProductResponse AddProduct(ProductRequest request)
        {
            ProductDAL Addproductdal = new ProductDAL();
            ProductResponse response = null;

            try
            {
                response = Addproductdal.AddProduct(request);
            }
            catch(Exception )
            {
                throw;
            }
            return response;

        }
    }
}
