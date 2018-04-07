using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Monitor : IParts
    {
        public void name()
        {
            Console.WriteLine("Part: Monitor");
        }

        public double getPrice()
        {
            double price = 499.99;
            return price;
        }
    }
}
