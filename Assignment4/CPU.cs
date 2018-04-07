using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class CPU : IParts
    {
        public void name()
        {
            Console.WriteLine("Part: CPU");
        }

        public double getPrice()
        {
            double price = 599.99; 

            return price;
        }
    }
}
