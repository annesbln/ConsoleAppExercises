using System;
using System.Collections.Generic;

namespace ConsoleAppExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();

            // Define an array called fruits that holds the following strings: "apple", "banana", and "orange".
            Exercise2();
                       
            //Construct a list of the first 5 prime numbers (2, 3, 5, 7, 11) called primeNumbers.
            Exercise3();

            // Create a new dictionary called inventory that holds 3 names of fruits, and the amount they are in stock.
            Exercise4();

            // Use string formatting to format the variables firstName, lastName and age.
            Exercise5();

            string x = "Hi!";
            int n = 10;
            // Print the value of variable X to the screen N number of times.
            Exercise6(x, n);
            
            // Print X to the console N time using a while loop.
            Exercise7(x, n);

            // Write a method that divides two numbers (provided as parameters). Tip: you will need to use the modifiers public and static.
            Exercise8();

            // Make a class car with the properties numTires = 4, year = 2000, and runs = true, and create three instances of it: car1, car2, and car3.
            Exercise9();

            // Make a class Vehicle with the properties string Type, int NumTires, int Year, and bool Runs, and create:
            // A car: Type = car with NumTires = 4 from Year = 2000 which Runs = true An oldcar: Type = car with NumTires = 4 from Year = 1980 
            // which Runs = false A bike: Type = bike with NumTires = 2 from Year = 2017 which Runs = true

            Exercise10();

            // Keep the console window open in debug mode.
            Console.WriteLine("Please press any key to exit.");
            Console.ReadKey();
        }

        private static void Exercise1()
        {
            string productName = "TV";
            int productYear = 2012;
            float productPrice = 279.99f;


            Console.WriteLine("Name: " + productName);
            Console.WriteLine("Year: " + productYear);
            Console.WriteLine("Price: " + productPrice);
        }

        private static void Exercise2()
        {
            string[] myArray = { "apple", "banana", "orange" };
            Console.WriteLine("The size of the array is: " + myArray.Length);

            foreach (string s in myArray)
            {
                Console.WriteLine(s);

            }
        }

        private static void Exercise3()
        {
            List<int> primeNumbers = new List<int>();
            int[] primeArray = { 2, 3, 5, 7, 11 };

            foreach (int i in primeArray)
            {
                primeNumbers.Add(i);
            }

            foreach (int i in primeNumbers)
            {
                Console.WriteLine(i);
            }
        }

        private static void Exercise4()
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();

            inventory.Add("apple", 3);
            inventory.Add("orange", 5);
            inventory.Add("banana", 2);

            foreach (KeyValuePair<string, int> entry in inventory)
            {
                Console.WriteLine(entry);
            }
        }

        private static void Exercise5()
        {
            string firstname = "John";
            string lastName = "Doe";
            int age = 27;

            string output = string.Format("{0} {1} is {2} years old.", firstname, lastName, age.ToString());

            Console.WriteLine(output);
        }

        private static void Exercise6(string hi, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(hi);
            }
        }

        private static void Exercise7(string hi, int n)
        {
            Console.WriteLine("Now while loop:");

            while (n > 0)
            {
                Console.WriteLine(hi);
                n--;
            }
        }

        private static void Exercise8()
        {
            Console.WriteLine("Please enter a number. This will be x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number. This will be y:");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(x + " divided by " + y + " is " + Divide(x, y));
        }

        private static void Exercise9()
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            Console.WriteLine("numTires of car1: " + car1.numTires);
            Console.WriteLine("year of car2: " + car2.year);
            Console.WriteLine("runs of car3: " + car3.runs);
        }

        private static void Exercise10()
        {
            Vehicle car = new Vehicle("car", 4, 2000, true);
            Vehicle oldcar = new Vehicle("car", 4, 1980, false);
            Vehicle bike = new Vehicle("bike", 2, 2017, true);

            Console.WriteLine("type of car: " + car.type);
            Console.WriteLine("number of runs for old car: " + oldcar.runs);
            Console.WriteLine("number of Tires for bike: " + bike.numTires);
        }

        private static double Divide(double x, double y)
        {
            return x / y;
        }

    }
}
