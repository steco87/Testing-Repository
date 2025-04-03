using Functions;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using static OOP___20feb_principii.Program;

namespace OOP___20feb_principii
{
    public class Program
    {
        static void OldLeassons()
        {
            System.Console.WriteLine("I am on the OldLeassons func");
            //int x;
            //x = 1;
            //int y;
            //y = 2;
            //int z;
            //z = x + y;
            //int age = 10;
            //double height = 100.5;
            //bool alive = true;


            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine("Your age is" + " " + age);
            //Console.Write("and your height is " + height + " " + "cm.");
            //Console.WriteLine(" Are you alive? " +  alive);


            //Constructori obiect = new Constructori("mesaj", "test");
            //Console.WriteLine(obiect.mesaj2 + " " + obiect.mesaj1);
            //Console.WriteLine("Test");
            //Console.Write("Automation");
            //Console.Write(" " + "Testing");
            ////This is a comment
            ///*
            // * multiline
            // * coment
            // * senteces
            // */
            //Console.Write(" " + "Line after multiline coment");


            //Console.ReadKey();

            //char symbol = '#';
            //string name = "Stefan";
            //string userName = symbol + name;


            //Console.WriteLine(userName);
            //Console.WriteLine("Your username is " + userName);
            //Console.WriteLine("Hello " + name);
            //Console.WriteLine(symbol);
            //Console.ReadKey();


            //const double pi = 3.14;


            //Console.WriteLine(pi);

            //double a = 1.213;
            //int b = Convert.ToInt32(a);
            //string c ="test";

            //Console.WriteLine(c.GetType());
            //Console.WriteLine(b.GetType());


            //int friends = 5;

            //friends = friends + 1;
            //friends += 1;
            //friends++;

            //friends = friends - 1;
            //friends -= 1;
            //friends--;

            //friends = friends * 2;
            //friends *= 2;

            //friends = friends / 2;
            //friends /= 2;

            //Console.WriteLine("Test");

            //Console.WriteLine("What's your age?");
            //String name = Console.ReadLine();

            //Console.WriteLine("What's your age?");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Hello " + name);
            //Console.WriteLine("You are " + age + " years old");

            //    var x = 3.14;
            //    var y = "1";
            //    int z = Convert.ToInt32(x);
            //    /*Console.WriteLine(z)*/;
            //    Console.WriteLine(Convert.ToInt32(y));
            //    /*Console.WriteLine(x)*/;

            //    Console.ReadKey();

            /*Console.WriteLine(z)*/
            //;
            //Console.WriteLine(Convert.ToInt32(y));
            ///*Console.WriteLine(x)*/
            //;

            //double a = 3.14;
            //int b = Convert.ToInt32(a);

            //Console.WriteLine(b.GetType());
            //Console.WriteLine(Mostenire.mesaj);

            //double a = 3.14;
            //int b = Convert.ToInt32(a);

            //int c = 123;
            //double d = Convert.ToDouble(c);

            //int e = 321;
            //String f = Convert.ToString(e);

            //String g = "$";
            //char h = Convert.ToChar(g);

            //String i = "true";
            //bool j = Convert.ToBoolean(i);

            //Console.WriteLine(f);

            //Console.WriteLine("Whats your name?");

            //int friends = 10;
            //friends = friends + 1;
            //friends += 2;
            //friends++;

            //friends = friends * 2;
            //friends *= 2;

            //friends = friends / 2;
            //friends /= 2;

            //int remainder = friends % 2;

            //Console.WriteLine(friends);

            //double x = 3.99;
            //double y = 5;

            //double a = Math.Pow(x, 3);
            //double b = Math.Sqrt(x);
            //double c = Math.Abs(x);
            //double d = Math.Round(x);
            //double e = Math.Ceiling(x);
            //double f = Math.Floor(x);
            //double g = Math.Max(x, y);

            //Random random = new Random();

            //int num1 = random.Next(1, 7);
            //int num2 = random.Next(1, 7);
            //int num3 = random.Next(1, 7);
            ////double num = random.NextDouble();

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);

            //string fullName = "Stefan";
            //string firstName = fullName.Substring(0, 3);
            //string LastName = fullName.Substring(3, 3);
            ////string phonenumber = "123-456-789";

            ////string username = fullName.Insert(0, "Pasoi ");


            ////fullName.ToUpper();
            ////fullName = fullName.ToLower();



            ////phonenumber = phonenumber.Replace("-""/");


            //Console.Write(firstName);
            //Console.Write(LastName );

            //Console.WriteLine("Please enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age > 100)
            //{
            //    Console.WriteLine("No games for you");
            //}
            //else if (age < 0)
            //{
            //    Console.WriteLine("You haven't been born yet!!");
            //}
            //else if (age > 100)

            //{
            //    Console.WriteLine("No games for you");
            //}
            //else
            //{
            //    Console.WriteLine("You must have 18 years old");
            //}

            //Console.WriteLine("What day is today");
            //String day = Console.ReadLine();

            //switch (day) 

            //{
            //    case "Monday":
            //        Console.WriteLine("It's Monday");
            //        break;

            //    case "Tuesday":
            //        Console.WriteLine("It's Tuesday");
            //        break;

            //    case "Wednesady":
            //        Console.WriteLine("It's Wednesady");
            //        break;

            //    case "Thursday":
            //        Console.WriteLine("It's Thursday");
            //        break;

            //    case "Friday":
            //        Console.WriteLine("It's Friday");
            //        break;

            //    case "Saturday":
            //        Console.WriteLine("It's Saturday");
            //        break;

            //    case "Sunday":
            //        Console.WriteLine("It's Sunday");
            //        break;

            //    default:
            //        Console.WriteLine(day + " is not a day");
            //        break;


            //Console.WriteLine("What's the temparature outside: (C)");
            //double temp = Convert.ToDouble(Console.ReadLine());

            //if (temp >= 10 && temp <= 20)
            //{
            //    Console.WriteLine("Is warm outside");
            //}

            //else if(temp<10)
            //{
            //    Console.WriteLine("It's cold  outside");

            //}
            //else
            //{
            //    Console.WriteLine("It's hot  outside");
            //}

            //else if (temp <= -30 || temp >= 30)
            //{
            //    Console.WriteLine("Do not go outside");
            //}

            //Console.Write("Enter your name: ");
            //String name = Console.ReadLine();

            ////while (name == "")
            ////{
            ////    Console.Write("Enter your name: ");
            ////    name = Console.ReadLine();
            ////}

            //while (1 == 1) 
            //{
            //    Console.WriteLine("TEST INFINTE LOOP");
            //}

            //Console.WriteLine("Hello " + name);

            //for (int i = 1; i<= 10;  i+=2) 

            //{ 
            //Console.WriteLine(i);
            //}

            //Console.WriteLine("How many rows?: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("How many columns?: ");
            //int columns = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("What symbol?: ");
            //string symbol = Console.ReadLine();

            //for (int i = 0; i < rows; i++) 

            //{
            //    for (int j = 0; j < columns; j++) 
            //    {
            //        Console.Write(symbol);
            //    }
        }

        static void MyFuncToday()
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
            Console.WriteLine("Average History note" + Historynotes.Sum() / 3);

            Array.Sort(Mathnotes);
        }

        static int Add10( int x)
        {
            return x + 10;
        }

        static void functieCareAfiseaza(string value) {
            Console.WriteLine("The result is " + value);
        }

        static void Arraylesson() 
        {
            string[] courses = { "Math", "History", "Programing" };
            int[] Mathnotes = new int[3] { 7, 10, 2, };
            int[] Historynotes = { 10, 9, 8, 5, 1, 2, 3 };
            double[] Programingnothes = new double[5] { 9.5, 5.5, 6.2, 3.5, 7.8 };
            string name = "Mark";

            //Console.WriteLine(name + "'s " + courses[0] + " notes are:" + Mathnotes[1] + ", " + Mathnotes[2] + " and " + courses[1] + " notes are:" + Historynotes[2] + ", " + Historynotes[6]);
            //Console.WriteLine(name + "'s " + courses[1] + " notes are:" + Historynotes[0] + ", " + Historynotes[1] + " and " + courses[1] + " notes are:" + Historynotes[2]);
            //Console.WriteLine(name + "'s " + courses[1] + " notes are:" + Programingnothes[0] + ", " + Programingnothes[1] + " and " + courses[1] + " notes are:" + Historynotes[2]);

            //Console.WriteLine("Max Math note" + Mathnotes.Max());
            //Console.WriteLine("Min History note" + Historynotes.Min());
            //Console.WriteLine("Average History note" + Historynotes.Average());

        }

        static void ListClass()
        {
             static void ObjectsList()
            {
                List<Player> players = new List<Player>();

                players.Add(new Player("Chad"));
                players.Add(new Player("Steve"));
                players.Add(new Player("Karen"));

                foreach (Player player in players)
                {
                    Console.WriteLine(player);
                }

                Console.ReadKey();
            }
        }
                        
        class CatOverride : AnimalOverride
        {
            public override void Speak()
            {
                Console.WriteLine("The cat goes *miau*");
            }
        }

        
       

     


        static void Main(string[] args)

        {
            Car[] garage = new Car[3];

            Car car1 = new Car("Dacia", 2010, "red");
            Car car2 = new Car("Opel", 2020, "blue");
            Car car3 = new Car("Skoda", 2030, "green");

            garage[0] = car1;
            garage[1] = car2;
            garage[3] = car3;






            //    ObjectsUdemy messages = new ObjectsUdemy("This is a new object created in class ObjectUdemy");
            //    Console.WriteLine(messages.Text);
            //ObjectsHuman Om1 = new ObjectsHuman("caprui", 20, 1996, "Paul");

            //ObjectsHuman Om2 = new ObjectsHuman("albastri", 20, 1990, "Andrei");
            //if (Om1.Age > Om2.Age)
            //{
            //    Console.WriteLine(Om1.Name);
            //}
            //else if (Om1.Age==Om2.Age) 
            //{
            //    Console.WriteLine("They have same ages");
            //}
            //else
            //{
            //    Console.WriteLine(Om2.Name);
            //}

            //ObjectsHuman Om3 = new ObjectsHuman("Stefan", 30);


            //Console.WriteLine(Om3.Name);

            //OverloadedConstructorsPizza pizza = new OverloadedConstructorsPizza("stuffed crust", "red sauce", "mozzarella");
            ////Console.WriteLine(pizza.);
            //DogOverride dog = new DogOverride();
            //dog.Speak();

            //CatOverride cat = new CatOverride();
            //cat.Speak();


            //Car car = new Car("OPel", 2024);
            //Console.WriteLine(car.ToString());

            //MyFuncToday();
            //string val =  Convert.ToString(Add10(20));
            //functieCareAfiseaza(val);
            //OldLeassons();
            //Arraylesson();
            //Arrayclass.Mymethod();
            //MultidimensionalArrayclass.SorteazaNote();
            //MultidimensionalArrayclass.SorteazaSiReturneazaNote();
            //MultidimensionalArrayclass.afiseazaValoryInArray();
            //MultidimensionalArrayclass.afiseazaLength();
            //MultidimensionalArrayclass.totalNotes();
            //MultidimensionalArrayclass.parkingLotFunc();
            //MultidimensionalArrayclass.Arraymutidimensional();
            //ListClass.StudentsList();
            //ListClass.GroupOfStudentsList();
            //ListClass.CarList();
            //ListClass.NotesList();
            //ListClass.FoodList();

            //ListOfObjects.ObjectsList();
            //ParamsKeyWord1.Parametri();
            //ConditionalOperator.ConditieTrueFalse();
            //StringInterpolation.StringPrescurtat();
            //Class1.Hello();
            //Class1.Student();
            //Human.Eat();


        }



    }

}


    public class Mostenire
{


    public static string mesaj = "Hello World";
}

public class Constructori
{
    public string mesaj2;
    public string mesaj1;
    public Constructori(string mesaj2p, string mesaj1p)
    {
        mesaj2 = mesaj2p;
        mesaj1 = mesaj1p;

    }
}





