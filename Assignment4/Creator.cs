using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Creator
    {
        public IParts FactoryMethod(string choice)
        {
            if(choice == null)
            {
                return null;
            }

            if (choice.Equals("CPU"))
            {
                return new CPU();
            }

            else if (choice.Equals("MONITOR"))
            {
                return new Monitor();
            }

            else if (choice.Equals("MEMORY"))
            {
                return new Memory();
            }

            else if (choice.Equals("KEYBOARD"))
            {
                return new Keyboard();
            }

            else if (choice.Equals("GRAPHIC"))
            {
                return new GraphicCard();
            }

            else
            {
                return null;
            }
        }
    }
}
