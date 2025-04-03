using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___20feb_principii
{
    public class ObjectsUdemy
    {
        public string Text { get; set; }
        public ObjectsUdemy(string text)
        {
            Text = text;
        }
        public void Messages()
        {
            Console.WriteLine("New Messages: ");
        }
    }
}
