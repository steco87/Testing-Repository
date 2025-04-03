using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___20feb_principii
{
    public class MultidimensionalArrayclass
    {
        static string[] courses = { "Math", "History", "Programing" };
        static int[] Mathnotes = new int[3] { 7, 10, 2, };
        static int[] Historynotes = { 10, 9, 8, 5, 1, 2, 3 };
        static double[] Programingnothes = new double[5] { 9.5, 5.5, 6.2, 3.5, 7.8 };
        static string name = "Mark";

        static String[] ford = { "Mustang", "F-150", "Explorer" };
        static String[] chevy = { "Corvette", "Camaro", "Silverado" };
        static String[] toyota = { "Corolla", "Camry", "Rav4" };
        static String[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
                                         { "Corvette", "Camaro", "Silverado" },
                                         { "Corolla", "Camry", "Rav4" } };




        public static void SorteazaNote()
        {
            Array.Sort(Historynotes);
            Console.WriteLine(Historynotes);
        }

        public static int[] SorteazaSiReturneazaNote()
        {
            Array.Sort(Historynotes);
            return Historynotes;
        }

        public static void afiseazaValoryInArray()
        {

            foreach (double arrayValue in Programingnothes)

            {
                Console.WriteLine(arrayValue);
            }
            Array.Sort(courses);
            foreach (string arrayValue in courses)
            {
                Console.WriteLine(arrayValue);
            }
        }

        public static void afiseazaLength()
        {
            for (int i = 0; i < Historynotes.GetLength(0); i++)
            {
                int j = Historynotes.GetLength(0);
                Console.WriteLine("Historynotes array leght: " + j);
                break;
            }
        }

        public static void totalNotes()
        {

            int Totalnotes = 5;
            int[] note = new int[Totalnotes];

            for (int i = 0; i < Totalnotes; i++)
            {
                Console.WriteLine("Enter note: " + i);
                note[i] = Convert.ToInt32(Console.ReadLine());

            }
        }

        public static void parkingLotFunc()
        {
            parkingLot[0, 2] = "Fusion";
            //foreach (String car in parkingLot)
            //{
            //    Console.Write(car + " ");
            //}
            for (int j = 0; j < parkingLot.GetLength(0); j++)
            {
                for (int k = 0; k < parkingLot.GetLength(1); k++)
                {
                    Console.Write(parkingLot[j, k] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Arraymutidimensional()

        {
           
            int[,] notes = { { 1, 3, 10 }, { 2, 4, 6 } };
            Console.WriteLine(notes[1, 2]);
            notes[0, 0] = 7;
            Console.WriteLine(notes[0, 0]);
            foreach (int i in notes)
            {
                Console.WriteLine("Array value " + i); 
            }

                        
        }

    }
}