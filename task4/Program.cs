using System;

class Student
{
    public string name;
    public int age;
    public double grade;

    public const string universityName = "Yarmouk University";

    public static int studentCount = 0;

    public Student(string n, int a, double g)
    {
        name = n;
        age = a;
        grade = g;
        studentCount++; 
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("University: " + universityName);
    }

    public void UpdateGrade(double newGrade)
    {
        grade = newGrade;
    }

    public bool IsPassed()
    {
        return grade >= 50;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Ahmad", 20, 60);
        Student s2 = new Student("Mohammad", 19, 45);
        Student s3 = new Student("Ali", 21, 80);

        s1.DisplayInfo();
        Console.WriteLine("Passed: " + s1.IsPassed());
        Console.WriteLine();

        s2.DisplayInfo();
        Console.WriteLine("Passed: " + s2.IsPassed());
        Console.WriteLine();

        s3.DisplayInfo();
        Console.WriteLine("Passed: " + s3.IsPassed());
        Console.WriteLine();

        s2.UpdateGrade(55);
        Console.WriteLine("After updating Mohammad grade:");
        Console.WriteLine("Passed: " + s2.IsPassed());
        Console.WriteLine();

        Console.WriteLine("Total Students: " + Student.studentCount);
    }

    // ------------------------------------------------------------
    // 1. WHAT IS A CLASS?
    // A class is a blueprint or template that defines the structure 
    // and behavior (fields, methods, constants) of real-world entities.
    // Here, the class "Student" describes what every student should have:
    // name, age, grade, and behaviors like DisplayInfo(), UpdateGrade(), etc.
    // ------------------------------------------------------------

    // ------------------------------------------------------------
    // 2. WHAT IS AN OBJECT?
    // An object is an actual instance created from a class.
    // It occupies memory and has real values for the fields.
    // ------------------------------------------------------------

    // EXAMPLE OF OBJECTS (from this code):
    // s1, s2, and s3 are three different Student objects.
    // Each object has its own name, age, grade, but all share
    // the same universityName (constant) and studentCount (static).



}