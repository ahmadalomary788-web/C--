using System;
namespace p2
{


    class Program
    {
        // Check even or odd
        static void CheckEvenOdd(int num)
        {
            if (num % 2 == 0)
                Console.WriteLine("The number " + num + " is even.");
            else
                Console.WriteLine("The number " + num + " is odd.");
        }

        // Find 2nd smallest
        static void SecondSmallest()
        {
            int[] arr = { 4, -3, 7, 2, 0 };
            Array.Sort(arr);
            Console.WriteLine("Second smallest: " + arr[1]);
        }

        // Calculate factorial
        static void Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial = " + fact);
        }

        // Find largest using foreach
        static void FindLargest()
        {
            int[] arr = { 3, 1, 4, 1, 5, 9 };
            int max = arr[0];

            foreach (int num in arr)
            {
                if (num > max)
                    max = num;
            }

            Console.WriteLine("Largest number: " + max);
        }

        // Number pattern
        static void NumberPattern(int n)
        {
            int num = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }

        // Star pattern
        static void StarPattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Sum even and odd
        static void SumEvenOdd()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int evenSum = 0, oddSum = 0;

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                    evenSum += num;
                else
                    oddSum += num;
            }

            Console.WriteLine("Even sum: " + evenSum);
            Console.WriteLine("Odd sum: " + oddSum);
        }

        // Find common elements
        static void CommonElements()
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 3, 4, 5, 6 };

            Console.Write("Common: ");

            foreach (int x in arr1)
            {
                foreach (int y in arr2)
                {
                    if (x == y)
                        Console.Write(x + " ");
                }
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            CheckEvenOdd(7);
            SecondSmallest();
            Factorial(5);
            FindLargest();
            NumberPattern(5);
            StarPattern(4);
            SumEvenOdd();
            CommonElements();
        }
    }
}