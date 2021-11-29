using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCBE;
using CTCDAL;

namespace CTCBAL
{
 public   class CATEGORIESBAL
    {
        public CategoriesResponse AddCatgory(CategoriesRequest request)
        {
            
           CategoriesDAL addCategoryDAL = new CategoriesDAL();
            CategoriesResponse response = null;
            try
            {
                response = addCategoryDAL.AddCatgory(request);
            }
            catch
            {
                throw;
            }
            return response;
        }

    }
}
