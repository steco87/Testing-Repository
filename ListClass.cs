using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OOP___20feb_principii
{
    internal class ListClass
    {
        public static void StudentsList() 
            {
            var students = new List<string>() { "Stefan", "Paul" };
            Console.WriteLine("student List: ");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            students.Add("Ion");
            students.Add("Cristi");
            Console.WriteLine("Students new List: ");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void GroupOfStudentsList() 
        {
            var groupOfStudents = new List<int>() { 10, 15, 20 };
            Console.WriteLine("Total number of student: " + groupOfStudents.Sum());
            Console.WriteLine("Groups total: " + groupOfStudents.Count());
        }

        public static void CarList() 
        {
            var Car = new List<string>() { "Volvo", "Dacia" };

            Car.Add("Skoda");
            Car.Add("BMW");
            Console.WriteLine("Car list: ");
            foreach (var item in Car) Console.WriteLine(item);
            {
                Console.WriteLine(Car);

            }
        }

        public static void NotesList()
        
        {
            var notes = new List<double>() { 1.5, 2.5, 3.5, };
            notes.Add(4.5);
            Console.WriteLine("Notes list: ");
            foreach (var item in notes) Console.WriteLine(item);
            {
                Console.WriteLine(notes);
            }
        }
        public static void FoodList()

        {
            //List = data structure that represents a list of objects that can be accessed by index.
                    //Similar to array, but can dynamically increase/ decrease in size
                    //using System.Collections.Generic;

            List<String> food = new List<String>();

            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            Console.WriteLine(food[1]);
            Console.WriteLine(food[1]);
            Console.WriteLine(food[2]);
            Console.WriteLine(food[3]);

            food.Remove("fries");
            food.Insert(0, "sushi");
            Console.WriteLine(food.Count);
            Console.WriteLine(food.IndexOf("pizza"));
            Console.WriteLine(food.LastIndexOf("fries"));
            Console.WriteLine(food.Contains("pizza"));
            food.Sort();
            food.Reverse();
            food.Clear();
            String[] foodArray = food.ToArray();

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            
            


            
            

        }
    }
}

