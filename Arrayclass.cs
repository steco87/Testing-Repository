using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{

    public class Arrayclass
    {
        static public void Mymethod()
        {
            string[] courses = { "Math", "History", "Programing" };
            int[] Mathnotes = new int[3] { 7, 10, 2 };
            int[] Historynotes = new int[3] { 10, 9, 8 };
            double[] Programingnothes = new double[5] { 9.5, 5.5, 6.2, 3.5, 7.8 };
            string name = "Mark";

            Console.WriteLine(name + "'s " + courses[0] + " notes are:" + Mathnotes[1] + ", " + Mathnotes[2] + " and " + courses[1] + " notes are:" + Historynotes[2]);
            Console.WriteLine(name + "'s " + courses[1] + " notes are:" + Historynotes[0] + ", " + Historynotes[1] + " and " + courses[1] + " notes are:" + Historynotes[2]);
            Console.WriteLine(name + "'s " + courses[1] + " notes are:" + Programingnothes[0] + ", " + Programingnothes[1] + " and " + courses[1] + " notes are:" + Historynotes[2]);

            Console.WriteLine("Max Math note" + Mathnotes.Max());
            Console.WriteLine("Min History note" + Historynotes.Min());
            Console.WriteLine("Average History note" + Historynotes.Average());



            Console.ReadKey();

        }

    }
}
