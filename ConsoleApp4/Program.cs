using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> students = new List<string>();
        Console.WriteLine("Enter 5 student names:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Name {i + 1}: ");
            string name = Console.ReadLine();
            name = name.Trim().ToUpper();
            students.Add(name);
        }
        Console.WriteLine();

        Console.WriteLine("Enter name to search: ");
        string search = Console.ReadLine().Trim().ToUpper();
        if (students.Contains(search))
        {
            Console.WriteLine("Student Found");

        }
        else
        {
            Console.WriteLine("Student Not Found");

        }
        Console.WriteLine();

        Console.WriteLine("Enter name to remove: ");
        string remove = Console.ReadLine().Trim().ToUpper();
        if (students.Remove(remove))
        {
            Console.WriteLine("Removed.");

        }
        else
        {
            Console.WriteLine("Not found.");

        }
        Console.WriteLine();
        // Part 4
        students.Sort();
        Console.WriteLine("\nSorted student list:");
        foreach (string s in students)
        {
            Console.WriteLine(s); 
        }
        Console.WriteLine();
        // Part 5
        Console.Write("\nEnter skills (comma separated): ");
        string skillsInput = Console.ReadLine();
        string[] skills = skillsInput.Split(',');
        Console.WriteLine("Skills:");
        foreach (string skill in skills)
        {
            Console.WriteLine(skill.Trim());
        }
        Console.WriteLine();
        // Part 6
        int[,] grades = new int[3, 3];
        Console.WriteLine("Enter grades for 3 students and 3 subjects:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Student {i + 1}, Subject {j + 1}: ");
                grades[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("All grades:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write(grades[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();

        // Modify one grade
        Console.WriteLine("Change grade (student row 0-2, subject 0-2): ");
        int row = Convert.ToInt32(Console.ReadLine());
        int col = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("New grade: ");
        grades[row, col] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Grade updated.");
        Console.WriteLine();

        // Part 7
        int[][] exams = new int[3][];
        exams[0] = new int[] { 85, 90 };
        exams[1] = new int[] { 78, 82, 88 };
        exams[2] = new int[] { 92, 76 };
        Console.WriteLine("Jagged array exam scores:");
        for (int i = 0; i < exams.Length; i++)
        {
            Console.Write($"Student {i + 1}: ");
            foreach (int score in exams[i])
            {
                Console.WriteLine(score+" ");   
            }

            Console.WriteLine();
        }
        Console.WriteLine();

        // Part 8: Password comparison
        Console.WriteLine("Enter admin password: ");
        string password = Console.ReadLine();
        if (password == "ADMIN123")
        {
            Console.WriteLine("Access Granted");
        }
        else
        {
            Console.WriteLine("Access Denied");
        }
    }
}