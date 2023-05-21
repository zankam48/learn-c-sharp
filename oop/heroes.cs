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
        private string gender;

        public Heroes(string aName, string aType, string aGender, int aPower = 0)
        {
            name = aName;
            type = aType;
            power = aPower;
            Gender = aGender;


            Console.WriteLine(name + " " + type + " " + power + " " + Gender);
        }

        public string isStrong()
        {
            string powerScale;
            if (power > 100)
            {
                powerScale = "he is very strong";
            }
            else if (power > 50 && power < 100)
            {
                powerScale = "he is ordinary";
            }
            else
            {
                powerScale = "he is weak";
            }
            return powerScale;
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "male" || value == "female")
                {
                    gender = value;
                }
                else
                {
                    gender = "im mental illness";
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Heroes heroes1 = new Heroes("hikamizna", "warrior", "male", 20);
            Console.WriteLine(heroes1.isStrong());
        }
    }
    
}


