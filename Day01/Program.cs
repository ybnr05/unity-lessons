using System;

class Program
{
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }

        return a / b;
    }

    static void Main()
    {
        Console.WriteLine("===== CALCULATOR =====");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        Console.Write("Choose an option: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = Add(num1, num2);
                break;

            case 2:
                result = Subtract(num1, num2);
                break;

            case 3:
                result = Multiply(num1, num2);
                break;

            case 4:
                result = Divide(num1, num2);
                break;

            default:
                Console.WriteLine("Invalid Choice");
                return;
        }

        Console.WriteLine("Result = " + result);
    }
}