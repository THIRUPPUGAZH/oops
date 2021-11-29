using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCBE
{
  public  class UserDisplayResponseBE:BaseResponse
    {
        public List<ProductRequest> UserDetails { get; set; }
        public string Statement { get; set; }
    }
}
