using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is: " + name);

            int age = 23;
            double price = 99.50;
            char grade = 'A';
            bool isLoggedIn = true;
            string address = "Irbid, Jordan";
            double temperature = 25.5;
            Console.WriteLine();

            Console.WriteLine("Part2 ");
            Console.WriteLine();

            Console.WriteLine("Age: " + age);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Is Logged In: " + isLoggedIn);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Temperature: " + temperature);
        }
    }
}