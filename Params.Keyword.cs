using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___20feb_principii
{
    public class ParamsKeyWord1 
    {
    
    public static void Parametri() 
        {
            double total = Checkout(1.5, 2.5, 3);
            Console.WriteLine(total);
            Console.ReadKey();
        }
        static double Checkout(double a)
        {
        return a;
        }

        static double Checkout(double a, double b) 
        
        {
            return a + b;
        }

        static double Checkout(double a, double b, double c) 
        {
        return (a + b + c);
        }

        static double Checkout(params double[] prices) 
        {
            double total = 0;
            foreach (double price in prices) 
            {
            total+= price;
            }
            return total;
        }
    

    }
    

}