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
        public int health;
        public int defense;

        private string gender;
        public static int heroesCount = 0;
        private HeroesClass heroesClass { get; set; }

        public Heroes(string aName, string aType, string aGender, HeroesClass aHeroesClass, int aHealth, int aPower, int aDefense)
        {
            name = aName;
            type = aType;

            power = aPower;
            health = aHealth;
            defense = aDefense; 

            Gender = aGender;
            heroesClass = aHeroesClass;
            heroesCount++;
        }

        public void getInfo()
        {
            Console.WriteLine(name + " " + type + " " + Gender + " " + heroesClass + " " + health + " " + power + " " + defense);
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

        public void healthUp(int up)
        {
            health += up;
        }

        public int getHealth()
        {
            return health;
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

        public int getHeroesCount()
        {
            return heroesCount;
        }
    }

    public enum HeroesClass
    {
        Warrior,
        Archer,
        Mage,
        Berserker
    }

    //public class Mage : Heroes
    //{
    //    public void 
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Heroes heroes1 = new Heroes("hikamizna", "warrior", "malexx", HeroesClass.Archer, 100, 30, 60);
            Heroes heroes2 = new Heroes("hikamiznax", "assassin", "male", HeroesClass.Mage, 120, 20, 50);
            Heroes heroes3 = new Heroes("hikamiznay", "archer", "female", HeroesClass.Berserker, 80, 40, 70);
            /*Console.WriteLine(heroes1.isStrong());
            Console.WriteLine(heroes2.isStrong());
            Console.WriteLine(heroes3.isStrong());
            Console.WriteLine(Heroes.heroesCount);
            Console.WriteLine(heroes1.getHeroesCount());*/

            heroes1.getInfo();
            Console.WriteLine(heroes1.getHealth()); 

        }
    }
    
}


