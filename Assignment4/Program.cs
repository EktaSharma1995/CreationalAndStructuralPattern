using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            GraphicCardCreator graphicCardCreator = new GraphicCardCreator();
            Computer computer = new Computer();

            Console.WriteLine("Parts of Computer and their prices");

            Console.WriteLine("Monitor");
            IParts monitor = c.FactoryMethod("MONITOR");
            computer.add(monitor);
            Console.WriteLine(monitor.getPrice());

            Console.WriteLine("Keyboard");
            IParts keyboard = c.FactoryMethod("KEYBOARD");
            computer.add(keyboard);
            Console.WriteLine(keyboard.getPrice());

            Console.WriteLine("Memory");
            IParts memory = c.FactoryMethod("MEMORY");
            computer.add(memory);
            Console.WriteLine(memory.getPrice());

            Console.WriteLine("CPU");
            IParts cpu = c.FactoryMethod("CPU");
            computer.add(cpu);
            Console.WriteLine(cpu.getPrice());

            Console.WriteLine("Graphic card");
            IParts graphicCard = c.FactoryMethod("GRAPHIC");
            
            computer.add(graphicCard);
            Console.WriteLine("Total price of graphic card");
            Console.WriteLine(graphicCard.getPrice());

            Console.WriteLine("Total price of Computer");
            Console.WriteLine(computer.getPrice());

            Console.WriteLine("Press Any key to exit");
            Console.ReadLine();

        }
    }
}
