using System;
using System.Collections.Generic;
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

        public string Name { get; set; }
        public ObjectsHuman(string ochi, int age, int birth, string name) 
        
        {
            Ochi = ochi;
            Age = age;
            Birth = birth;
            Name = name;
        }

        public ObjectsHuman(string name, int age)

        { 
            Name= name;
            Age = age;

        }
    }
}
