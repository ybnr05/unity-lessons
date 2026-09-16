using System;

class Student
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();

        student1.Name = "Bhuvan";
        student1.Age = 22;

        Student student2 = new Student();

        student2.Name = "Alex";
        student2.Age = 20;

        Console.WriteLine("Student 1");
        Console.WriteLine("Name: " + student1.Name);
        Console.WriteLine("Age : " + student1.Age);

        Console.WriteLine();

        Console.WriteLine("Student 2");
        Console.WriteLine("Name: " + student2.Name);
        Console.WriteLine("Age : " + student2.Age);
    }
}