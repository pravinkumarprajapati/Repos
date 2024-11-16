using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyControl
{
    public class ServerClass
    {
        public void Display()
        {
            Thread.Sleep(5000);
            Console.WriteLine($"ServerClass.Display");
        }
    }
}
