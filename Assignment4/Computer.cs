using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Computer : IParts
    {
        private List<IParts> list = new List<IParts>();

        public void name()
        {
            Console.WriteLine("Part: Computer");
        }

        public double getPrice()
        {
            double totalPrice = 0;

            foreach(IParts iparts in list)
            {
                totalPrice += iparts.getPrice();
            }
            return totalPrice;
        }

        public void add(IParts parts)
        {
            this.list.Add(parts);
        }

        public void remove(IParts parts)
        {
            list.Remove(parts);
        }

        public void clear()
        {
            Console.WriteLine("Clear all parts");
            this.list.Clear();
        }
    }
}
