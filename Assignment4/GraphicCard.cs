using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class GraphicCard : IParts
    {
        private List<IParts> list = new List<IParts>();
        GraphicCardCreator gCreator = new GraphicCardCreator();

        public GraphicCard()
        {
            Console.WriteLine("GPU");
            IParts gpu = gCreator.FactoryMethod("GPU");
            this.list.Add(gpu);
            Console.WriteLine(gpu.getPrice());

            Console.WriteLine("Graphic Card Memory");
            IParts graphicCardMemory = gCreator.FactoryMethod("GraphicCardMemory");
            this.list.Add(graphicCardMemory);
            Console.WriteLine(graphicCardMemory.getPrice());
        }

        public void name()
        {
            Console.WriteLine("Part: Graphic Card");
        }

        public double getPrice()
        {
            double totalPrice = 0;

            foreach (IParts iparts in list)
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
