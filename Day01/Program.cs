using System;

class Program
{
    static void PrintHeader()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("STUDENT REPORT");
        Console.WriteLine("=========================");
    }

    static void DisplayStudent(string name, int marks)
    {
        Console.WriteLine("Name  : " + name);
        Console.WriteLine("Marks : " + marks);
    }

    static string CalculateGrade(int marks)
    {
        if (marks >= 90)
        {
            return "A";
        }
        else if (marks >= 75)
        {
            return "B";
        }
        else if (marks >= 60)
        {
            return "C";
        }
        else
        {
            return "F";
        }
    }

    static void Main()
    {
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        int marks = int.Parse(Console.ReadLine());

        PrintHeader();

        DisplayStudent(name, marks);

        string grade = CalculateGrade(marks);

        Console.WriteLine("Grade : " + grade);
    }
}