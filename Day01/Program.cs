using System;

class Student
{
    public string Name;
    public int Age;

    public void Introduce()
    {
        Console.WriteLine("Hello, my name is " + Name);
        Console.WriteLine("I am " + Age + " years old.");
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();

        student1.Name = "Bhuvan";
        student1.Age = 22;

        student1.Introduce();
    }
}