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

        public string isStrong()
        {
            string powerScale;
            if ( power > 100)
            {
                powerScale = "he is very strong";
            }
            else if ( power > 50 && power < 100)
            {
                powerScale = "he is ordinary";
            }
            else
            {
                powerScale = "he is weak";
            }
            return powerScale;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Heroes heroes1 = new Heroes("hikamizna", "warrior", 20);
            Console.WriteLine(heroes1.isStrong());
        }
    }
    
}


