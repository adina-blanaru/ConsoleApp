using System;
using System.Collections.Generic;

namespace HelloWorldProj
{
    class Sept30Homework
    {
        // https://www.learncs.org/

        // Exercise 1
        public static void ExercisePrintHelloWorld()
        {
            System.Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }

        //Exercise 2
        public static void ExerciseVariablesAndTypes()
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
        public static void ExerciseConditionals()
        {
            int guess = 500;
        
            // Write conditional here
            if (guess == 500) {
        	    Console.WriteLine("Success!");
            }
            Console.ReadKey();
        }

        //Exercise 4
        public static void ExerciseArrays()    //arrays have a fixed size
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
        public static void ExerciseLists() //lists are dynamic sized
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
        public static void ExerciseDictionary()
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
        public static void ExerciseStrings()
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
        public static void ExerciseForLoops()
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
        public static void ExerciseWhileLoops()
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
        public static void ExerciseMethods()
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

        //Exercise 11 and 12 are done in Program.cs

    }
}
