using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorldProj
{
    class Oct07Course
    {
        public static void Oct7_Lists()
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

        public static void Oct7_Arrays()
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

        public static void Oct7_DoWhileLoop()
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

        public static void Oct7_WhileLoop()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"i este {i}");
                i++;
            }
        }

        public static void Oct7_ForLoop()
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

        public static int Oct7_SwitchCase(int a)
        {
            switch (a % 2)
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

        public static void Oct7_IfElseNested()
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

        public static void Oct7_IfElse()
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

        public static int Oct7_Sum()
        {
            var a = 1;
            var b = 2;
            return a + b;
        }
    }    
}
