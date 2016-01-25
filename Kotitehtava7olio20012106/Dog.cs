using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava7olio20012106
{
    class Dog : Creature
    {
        public string Breed { get; set; }

        // default constructor
        public Dog()
        {
        }

        public void DogWrite()
        {
            Console.WriteLine("Dog data : ");
            Console.WriteLine("- Name : " + Name);
            Console.WriteLine("- Age : " + Age);
            Console.WriteLine("- Breed : " + Breed);
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " " + Breed;
        }
    }
}
