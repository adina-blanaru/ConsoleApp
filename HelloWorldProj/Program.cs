using System;
using System.Collections.Generic;

namespace HelloWorldProj
{
    class Program
    {
        static void Main()
        {
            Oct7_Lists();
            Console.ReadKey();
        }

        //----------------------------------

        // October 7

        private static void Oct7_Lists()
        {
            List<int> numerePrime = new List<int>();
            numerePrime.Add(1);
            numerePrime.Add(3);
            numerePrime.Add(5);
            numerePrime.Add(7);
            numerePrime.Add(11);

            foreach (var numarPrim in numerePrime)
            {
                Console.WriteLine(numarPrim);
            }
        }

        private static void Oct7_Arrays()
        {
            int i;
            int[] myIntArray = new int[] { 17, 21, 34, 4, 15, 49 };
            string[] myStringArray = new string[] { "BV", "IS", "CJ", "B" };

            Console.WriteLine($"Prima valoare este: {myIntArray[0]}");
            myIntArray[0] += 100;
            Console.WriteLine($"Valoarea cu 100 mai mare este: {myIntArray[0]}");

            Console.WriteLine($"Maximul este: {myIntArray.Max()}");
            Console.WriteLine($"Suma este: {myIntArray.Sum()}");
            Console.WriteLine($"Media este: {myIntArray.Average()}");

            Array.Sort(myIntArray);
            for (Console.WriteLine("Valorile sortate crescator sunt:"), i = 0; i < myIntArray.Length; i++)
            {
                Console.WriteLine(myIntArray[i]);
            }

            Array.Reverse(myIntArray);
            for (Console.WriteLine("Valorile sortate descrescator sunt:"), i = 0; i < myIntArray.Length; i++)
            {
                Console.WriteLine(myIntArray[i]);
            }

            Array.ForEach(myIntArray, n => Console.WriteLine(n));

            for (Console.WriteLine("Valorile combinate sunt:"), i = 0; i < myIntArray.Length; i++)
            {
                if (i > myStringArray.Length - 1)
                {
                    break;
                }
                Console.WriteLine($"{myStringArray[i]} {myIntArray[i]}");
            }

            for (Console.WriteLine("Valorile oraselor sunt:"), i = 0; i < myStringArray.Length; i++)
            {
                Console.WriteLine(myStringArray[i]);
            }
        }

        private static void Oct7_DoWhileLoop()
        {
            int i = 0;
            do
            {
                Console.WriteLine($"i este {i}");
                if (i > 5) 
                {
                    break;
                }
                i++;
            } while (i < 10);
        }

        private static void Oct7_WhileLoop()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"i este {i}");
                i++;            
            }
        }

        private static void Oct7_ForLoop()
        {
            int i = 0, j = 5;

            for (Console.WriteLine("Start:"); i + j < 20; Console.WriteLine($"Initializatorul: i = {i}, j = {j}"), i++, j++)
            {
            }

            for (i = 0, j = 0; i + j < 5; i++, j++)
            {
                Console.WriteLine($"Valoarea lui i: {i} si a lui j: {j}");
            }

            Console.WriteLine("Valorile lui i, descrescator:");
            for (i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        private static int Oct7_SwitchCase(int a)
        {
            switch (a%2)
            {
                case 0:
                    Console.WriteLine($"{a} este par");
                    break;
                default:
                    Console.WriteLine($"{a} este impar");
                    break;
            }
            return a;           
        }

        private static void Oct7_IfElseNested()
        {
            var a = 30;
            var b = 20;

            if (a != b)
            {
                if (a < b)
                {
                    Console.WriteLine(a + " < " + b);
                }
                else if (a > b)
                {
                    Console.WriteLine(a + " > " + b);
                }
            }
            else
            {
                Console.WriteLine(a + " = " + b);
            }
        }

        private static void Oct7_IfElse()
        {
            var a = 30;
            var b = 20;

            if (a < b)
            {
                Console.WriteLine(a + " < " + b);
            }
            else if (a > b)
            {
                Console.WriteLine(a + " > " + b);
            }
            else
            {
                Console.WriteLine(a + " = " + b);
            }
        }

        private static int Oct7_Sum()
        {
            var a = 1;
            var b = 2;
            return a + b;
        }

        //----------------------------------

        // October 5
        private static void Oct5() {
            //// Ex 1
            //// User details
            //var firstName = "Adina";
            //string lastName;
            //string city;
            //int age = 31;
            //string address;

            //Console.WriteLine("Enter your first name:\n");
            //firstName = Console.ReadLine();
            //Console.WriteLine("Enter your last name:\n");
            //lastName = Console.ReadLine();

            //Console.WriteLine("Enter your city:\n");
            //city = Console.ReadLine();

            //Console.WriteLine("Enter your age:\n");
            //age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your address:\n");
            //address = Console.ReadLine();

            //// Output values

            //Console.WriteLine("=========================");
            //Console.WriteLine("User Details");
            //Console.WriteLine("=========================\n");
            ////Console.WriteLine("Name: {0} {1}", firstName, lastName);
            ////Console.WriteLine(String.Format("Name: {0} {1}", firstName, lastName));
            //Console.WriteLine($"Name: {firstName} {lastName}");
            //Console.WriteLine($"City: {city}");
            //Console.WriteLine($"Age: {age}");
            //Console.WriteLine($"Address: {address}");

            //Console.ReadKey();
            //--------------------------------------------------------------------------------

            // Ex2
            string firstName;
            string lastName;
            string demoName = "Adina";

            bool status;

            Console.WriteLine("Enter your first name:");
            firstName = Console.ReadLine();
            //Console.WriteLine("\nEnter your last name:");
            //lastName = Console.ReadLine();

            // compare
            //Console.WriteLine(firstName.CompareTo(demoName));

            status = firstName.Contains(demoName);
            //Console.WriteLine($"First Name contains demo name is {status}");

            //Console.WriteLine($"First Name ends with 'a' is { firstName.EndsWith("a")}");

            //Console.WriteLine($"Index of 'a' in first name is {firstName.IndexOf("a")}");
            //Console.WriteLine($"Last index of 'a' in first name is {firstName.LastIndexOf("a")}");

            //Console.WriteLine($"First name lower: {firstName.ToLower()} and first name upper: {firstName.ToUpper()}");

            //Console.WriteLine($"Remove everything after index 2 from first name: {firstName.Remove(2)}");

            //Console.WriteLine($"Replace 'd' from first name with 'D': {firstName.Replace("d", "D")}");

            Console.WriteLine($"First name has {firstName.Length} letters");
            Console.ReadLine();
        }

        //----------------------------------

        // Sep 30 homework

        // Exercise 1
        static void ExercisePrintHelloWorld()
        {
            System.Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }

        //Exercise 2
        static void ExerciseVariablesAndTypes()
        {
           // write your code here
           string productName = "TV";
           int productYear = 2012;
           float productPrice = 279.99f;    //TODO how do you specify the f letter when using variables?

           // test code
           Console.WriteLine("productName: " + productName);
           Console.WriteLine("productYear: " + productYear);
           Console.WriteLine("productPrice: " + productPrice);
           Console.ReadKey();
        }

        //Exercise 3
        static void ExerciseConditionals()
        {
            int guess = 500;
        
            // Write conditional here
            if (guess == 500) {
        	    Console.WriteLine("Success!");
            }
            Console.ReadKey();
        }

        //Exercise 4
        static void ExerciseArrays()    //arrays have a fixed size
        {
            // write your code here
            string[] fruits = {"apple", "banana", "orange"};        

            // test code
            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[2]);     
            Console.ReadKey();
        }

        //Exercise 5
        static void ExerciseLists() //lists are dynamic sized
        {
            // TODO: add your code here
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Add(11);

            // test code
            Console.WriteLine(primeNumbers.Count);
            Console.WriteLine(primeNumbers[0]);
            Console.WriteLine(primeNumbers[1]);
            Console.WriteLine(primeNumbers[2]);
            Console.WriteLine(primeNumbers[3]);
            Console.WriteLine(primeNumbers[4]);
            Console.ReadKey();
        }

        //Exercise 6
        static void ExerciseDictionary()
        {
            // TODO: add the inventory dictionary here
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            inventory.Add("apple", 3);
            inventory["orange"] = 5;
            inventory.Add("banana", 2);

            Console.WriteLine(inventory["apple"]);
            Console.WriteLine(inventory["orange"]);
            Console.WriteLine(inventory["banana"]);
            Console.ReadKey();
        }

        //Exercise 7
        static void ExerciseStrings()
        {
            string firstName = "John";
            string lastName = "Doe";
            int age = 27;

            // TODO: change this
            string sentence = String.Format("{0} {1} is {2} years old.", firstName, lastName, age);

            Console.WriteLine(sentence);
            Console.ReadKey();
        }

        //Exercise 8
        static void ExerciseForLoops()
        {
            string x = "Hi";
            int n = 10;

            // write for loop here
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }

        //Exercise 9
        static void ExerciseWhileLoops()
        {
            string x = "Hi";
            int n = 10;

            //write while loop here
            int i = 0;
            while (i < n)
            {
                Console.WriteLine(x);
                i++;
            }
            Console.ReadKey();
        }

        //Exercise 10
        static void ExerciseMethods()
        {
            int x = 2;
            int y = 2;
            int a = Foo(x, y);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        //write method Foo here
        static int Foo(int x, int y)
        {
            return x / y;
        }
    }

    //Exercise 11
    public class ExerciseBasicClasses
    {
        public static void Test()
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            // Test code
            Console.WriteLine(car1.numTires);
            Console.WriteLine(car2.year);
            Console.WriteLine(car3.runs);
            Console.ReadKey();
        }
    }
    //write Car class here
    public class Car
    {
        public int numTires = 4;
        public int year = 2000;
        public bool runs = true;

    }

    //Exercise 12
    public class ExerciseClassProperties
    {
        public static void Test()
        {
            //Create vehicles here
            Vehicle car = new Vehicle("car", 4, 2000, true);
            Vehicle oldcar = new Vehicle("car", 4, 1980, false);
            Vehicle bike = new Vehicle("bike", 2, 2017, true);

            // Test code
            Console.WriteLine(car.Type);
            Console.WriteLine(oldcar.Runs);
            Console.WriteLine(bike.NumTires);
            Console.ReadKey();
        }
    }
    //Write Vehicle class here
    public class Vehicle
    {
        public string Type;
        public int NumTires;
        public int Year;
        public bool Runs;

        public Vehicle(string type, int numtires, int year, bool runs)
        {
            Type = type;
            NumTires = numtires;
            Year = year;
            Runs = runs;
        }
    }
}
