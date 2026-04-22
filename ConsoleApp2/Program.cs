using System;
using System.Linq; 

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Porsche", "Dodge" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
             Console.WriteLine("Cars Array Length: " + cars.Length); 
            Console.WriteLine(cars[1]);

            Array.Resize(ref cars, cars.Length + 3);
            cars[5] = "Merceds";
            cars[6] = "Chevrolet";
            cars[7] = "Mclaren";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Console.WriteLine("Cars Array Length: " + cars.Length);
            cars[5] = "";
            Console.WriteLine("Cars Array Length: " + cars.Length);
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            /*
             
            string[] myCars = new string[3];
            for (int i = 0; i < myCars.Length; i++)
            {
                myCars[i] = Console.ReadLine();
            }

            */



            int[] myNum = new int[5];
            myNum[0] = 10;
            myNum[1] = 20;
            myNum[2] = 15;
            myNum[3] = 5;
            for (int i = 0; i < myNum.Length; i++)
            {
                Console.WriteLine(myNum[i]);
            }


            Array.Sort(myNum); 

            Console.WriteLine("--- Sorted Numbers ---");
            for (int i = 0; i < myNum.Length; i++)
            {
                Console.WriteLine(myNum[i]);
            }

            Console.WriteLine("Max: " + myNum.Max()); 
            Console.WriteLine("Min: " + myNum.Min()); 
            Console.WriteLine("Sum: " + myNum.Sum()); 

            char[] myChar = new char[] { 'A' };

            Console.WriteLine(10 > 9); 

            bool isloggedin = true;
            bool isprime = false;

            Console.WriteLine(isloggedin);
            Console.WriteLine(isprime);    

            if (!isloggedin) 
            {
                Console.WriteLine("User is not logged in");
            }

            Console.WriteLine(5 > 3 || 3 < 5); 

            int gpa = 85;

            Console.WriteLine("--- GPA Grade ---");
            if (gpa >= 90)
            {
                Console.WriteLine("A");
            }
            else if (gpa < 90 && gpa >= 80)
            {
                Console.WriteLine("B"); 
            }
            else
            {
                Console.WriteLine("F");
            }



        }
    }
}