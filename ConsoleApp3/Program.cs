using System.Drawing;
using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Fruits = new string[] { "Apple", "Banana", "Mango", "Orange", "Pineapple" };
            for (int i = 0; i < Fruits.Length; i++)
            {
                Console.WriteLine("Fruit " + i + ": " + Fruits[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter 5 numbers");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Number " + i + ": " + numbers[i]);
            }
            Console.WriteLine();    



            Console.Write("Orginal:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Array.Reverse(numbers);
            Console.WriteLine("Reverse");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            string[] colors = { "Red", "blue", "green", "Rose", "Yellow", "RUBY" };
            int count = 0;
            Console.WriteLine("The colors are:");
            foreach (string color in colors)
            {
                Console.WriteLine(color);

                if (color.ToLower().StartsWith("r"))
                {
                    count++; 
                }
            }
            Console.WriteLine("Number of colors starting with R = " + count);
            Console.WriteLine();
            int[] num = new int[6];

            Console.WriteLine("Enter 6 numbers:");

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = num.Min();
            int max = num.Max();
            int sum = num.Sum();
            double average = num.Average();
            Array.Sort(num);
            Console.Write("Sort:"+"");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + ", ");
            }

        }
    }
}
