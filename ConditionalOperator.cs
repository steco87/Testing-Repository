using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___20feb_principii
{
    internal class ConditionalOperator

    {
        public static void ConditieTrueFalse() 
        {
            double temperature = 20;
            String message;

            if(temperature >= 20) 
            {
                message = "It's warm outside!";
            }
            else 
            {
                message = "It's cold outside!";
            }
            Console.WriteLine(message);
            temperature = 10;
            message = (temperature >= 20) ? "warn" : "cold";
            Console.WriteLine(message);

        }
    }
}
