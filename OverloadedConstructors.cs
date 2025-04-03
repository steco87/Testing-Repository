using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___20feb_principii
{
    

    internal class OverloadedConstructorsPizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public OverloadedConstructorsPizza(String bread, String sauce, String cheese, String topping) 
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }

        public OverloadedConstructorsPizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            
        }
        public OverloadedConstructorsPizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
            

        }

    }
}
