using System;
using System.Collections.Generic;

namespace HelloWorldProj
{
    class Oct05Course
    {
        public static void Oct5()
        {
            // Ex 1 - User details
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
            
            Console.WriteLine("\nEnter your last name:");
            lastName = Console.ReadLine();

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
    }    
}
