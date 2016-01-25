using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava7olio20012106
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one Person object
            Human human1 = new Human();
            human1.Name = "Sami";
            human1.Age = 20;
            human1.Height = 171;

            Human human2 = new Human();
            human2.Name = "Vera";
            human2.Age = 18;
            human2.Height = 162;

            Dog dog1 = new Dog();
            dog1.Name = "Cookie";
            dog1.Age = 0;
            dog1.Breed = "Huskymix";

            Dog dog2 = new Dog();
            dog2.Name = "Vilma";
            dog2.Age = 5;
            dog2.Breed = "Mix";





            // do something methods
            human1.HumanWrite();
            Console.ReadLine();
            human2.HumanWrite();
            Console.ReadLine();
            dog1.DogWrite();
            Console.ReadLine();
            dog2.DogWrite();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
