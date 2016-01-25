using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava7olio20012106
{
    class Creature
    {
        public string Name { get; set; }
        public int Age { get; set; }


        // return Item data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
