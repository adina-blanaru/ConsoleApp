using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorldProj
{
    class Program
    {
        static void Main()
        {
            //HomeworkOct7.Ex23_26_27();
            //CourseOct7.Oct7_IfElse();
            Console.ReadKey();
        }
    }



    //--------------------------------------------------------------------------------

    //Homework Sept 30 https://www.learncs.org/

    //Exercise 11
    public static class ExerciseBasicClasses
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
    public static class ExerciseClassProperties
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
