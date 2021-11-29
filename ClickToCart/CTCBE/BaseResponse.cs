using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCBE
{
public    class BaseResponse
    {
        public int status { get; set; }
        public int ErrorNo { get; set; }
        public string ErrorMessage { get; set; }
    }
}
