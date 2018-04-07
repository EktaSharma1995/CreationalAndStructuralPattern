using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Keyboard : IParts
    {
        public void name()
        {
            Console.WriteLine("Part: Keyboard");
        }

        public double getPrice()
        {
            double price = 199.99;

            return price;
        }
    }
}
