using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___20feb_principii
{
    public class Car
    {
        
        public String model;
        public int year;
        public string color;

        public  Car(String model, int year,string color)
        {
            this.model = model;
            this.year = year;
            this.color = color;
        }

        //public override String ToString()
        //{
        //    return "This is a " + model + " from " + year;
        //}
    }
}
