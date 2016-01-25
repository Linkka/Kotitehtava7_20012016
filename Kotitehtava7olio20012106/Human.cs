using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava7olio20012106
{
    class Human : Creature
    {
        public int Height { get; set; }

        // default constructor
        public Human()
        {
        }

        public void HumanWrite()
        {
            Console.WriteLine("Human data : ");
            Console.WriteLine("- Name : " + Name);
            Console.WriteLine("- Age : " + Age);
            Console.WriteLine("- Height : " + Height + "cm");
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " " + Height;
        }
    }
}
