using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class GPU : IParts
    {
        public void name()
        {
            Console.WriteLine("Part: GPU");
        }

        public double getPrice()
        {
            double price = 99.99;

            return price;
        }
    }
}
