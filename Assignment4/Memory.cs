using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Memory : IParts
    {
        public void name()
        {
            Console.WriteLine("Part: Memory");
        }

        public double getPrice()
        {
            double price = 999.99;
            return price;
        }
    }
}
