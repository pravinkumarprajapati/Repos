using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyControl
{
    public class ThreadHelperClass
    {
        public string Display()
        {
            Thread.Sleep(1000);
            return $"Message from ThreadHelperClass.Display";
        }
    }
}
