using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} X {i} = {num * i}");
        }
    }
}