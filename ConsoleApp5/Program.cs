using System;

namespace CarExhibitionDemo
{
    public class Car
    {
        // 1. Fields 
        public string Brand;
        public string Model;
        public int Year;

        // 2. Readonly Field
        public readonly string ChassisNumber;

        // 3. Static Field
        public static int TotalCarsCreated = 0;

        // 4. Constant
        public const int MaxCarsAllowed = 50;

        public Car(string brand, string model, int year, string chassisNumber)
        {
            Brand = brand;
            Model = model;
            Year = year;
            ChassisNumber = chassisNumber;

            TotalCarsCreated++;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model} ({Year})");
            Console.WriteLine($"   Chassis: {ChassisNumber}");
            Console.WriteLine($"   Total cars in gallery : {TotalCarsCreated}");
            Console.WriteLine($"   Max cars allowed (const): {MaxCarsAllowed}");
            Console.WriteLine("-----------------------------------");
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Static field TotalCarsCreated (before any car): {Car.TotalCarsCreated}");
            Console.WriteLine($"Const MaxCarsAllowed: {Car.MaxCarsAllowed}");

            Car car1 = new Car("BMW", "M5", 2024, "ABC123");
            Car car2 = new Car("BMW", "i8", 2017, "XYZ789");
            Car car3 = new Car("Porsche", "GT3", 2021, "DEF456");

            car1.DisplayInfo();
            car2.DisplayInfo();
            car3.DisplayInfo();


            // 1. Instance fields
            car1.Brand = "Lamborghini";  // Changing only car1's brand

            Console.WriteLine($"After change: car1 brand = {car1.Brand}");

            // 2. Static field
            Console.WriteLine($"Total cars created: {Car.TotalCarsCreated} ");

            Car.TotalCarsCreated = 100; // Modifying the static field

            Console.WriteLine($"After manually setting TotalCarsCreated = 100:");
            Console.WriteLine($"Class access: {Car.TotalCarsCreated}\n");

            
        }
    }
}