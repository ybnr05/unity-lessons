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

        Console.WriteLine("Name: " + student1.Name);
        Console.WriteLine("Age : " + student1.Age);
    }
}