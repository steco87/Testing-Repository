using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___20feb_principii
{
    public class StringInterpolation 
    {
        public static void StringPrescurtat() 
        {
            String firstName = "Stefan";
            String lastName = "Pasoi";
            int age = 37;
            Console.WriteLine($"Hello { firstName} { lastName}");
            Console.WriteLine($"My age is {age,10} old.");

        }
    }
    
     
    
}
