using System;

class Student
{
    private int age;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            age = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Age = 22;

        Console.WriteLine("Age: " + student.Age);
    }
}