using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_basic.oop
{
    class Heroes
    {
        public string name;
        public string type;
        public int power;

        public Heroes(string aName, string aType, int aPower = 0)
        {
            name = aName;
            type = aType;
            power = aPower;

            Console.WriteLine(name + " " + type + " " + power);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Heroes heroes1 = new Heroes("hikamizna", "warrior", 20);

            Console.WriteLine(heroes1.name);
        }
    }
    
}


