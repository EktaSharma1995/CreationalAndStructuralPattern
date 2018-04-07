using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class GraphicCardMemory : IParts
    {
        public void name()
        {
            Console.WriteLine("Part: Graphic Card Memory ");
        }

        public double getPrice()
        {
            double price = 299.99;
            return price;
        }
    }
}
