using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___20feb_principii
{
    internal class Class1
    {
       public static void Hello()
        {
            Console.WriteLine("Hello, this is a message from Class1 class");
        }
        
        public static void Student()
        
            
        {
            String firstname = "Paul";
            String lastname = "Bro";
            int age = 20;
            Console.WriteLine($"Hello, my name is {firstname} {lastname}.");
            Console.WriteLine($"I am {age,5} years old");
        }

    }
}
