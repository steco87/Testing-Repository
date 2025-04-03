using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___20feb_principii
{
    internal class DogOverride : AnimalOverride
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }
}
