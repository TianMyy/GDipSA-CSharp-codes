using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._04_Exception
{
    class BadTriangleException:Exception
    {
        public BadTriangleException():base() { }
        public BadTriangleException(string message):base(message) { }
    }
}
