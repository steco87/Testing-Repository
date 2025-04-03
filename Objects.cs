using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP___20feb_principii
{
    
    public class ObjectsHuman
    {
        public string Ochi {  get; set; }
        public int Age {  get; set; }
        public int Birth { get; set; }
        public string Color {  get; set; }

        public string Name { get; set; }
        public ObjectsHuman(string ochi, int age, int birth, string name, string color) 
        
        {
            Ochi = ochi;
            Age = age;
            Birth = birth;
            Name = name;
            Color = color;
        }

        public ObjectsHuman(string name, int age)

        { 
            Name= name;
            Age = age;


        }
    }
}
