using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCBE;
using CTCDAL;

namespace CTCBAL
{
    public class ProductDisplayBAL
    {
        public ProductDisplayResponse delete(ProductDisplayRequest request)
        {
            ProductDisplayResponse response = null;
            ProductDisplay objProductDetails = new ProductDisplay();

            response = objProductDetails.delete(request);
            return response;

        }
        public ProductDisplayResponse UpdateData(ProductRequest request)
        {
            ProductDisplayResponse response = null;
            ProductDisplay GetDataDal = new ProductDisplay();
            response = GetDataDal.UpdateData(request);
            return response;
        }
        }
  }

