using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class GraphicCardCreator
    {
        public IParts FactoryMethod(string choice)
        {
            if (choice == null)
            {
                return null;
            }

            if (choice.Equals("GPU"))
            {
                return new GPU();
            }

            else if (choice.Equals("GraphicCardMemory"))
            {
                return new GraphicCardMemory();
            }

            else
            {
                return null;
            }
        }
    }
}
