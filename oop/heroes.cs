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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Heroes heroes1 = new Heroes();
            heroes1.name = "Hikamizan";
            Console.WriteLine(heroes1.name);
        }
    }
    
}


