using System;

class Program
{
    
    static void Main()
    {
       Console.WriteLine("====Simple calculator====");
       Console.WriteLine("1. Addition");
       Console.WriteLine("2. Subtraction");
       Console.WriteLine("3. Multiplication");
       Console.WriteLine("4. Division");

       Console.Write("Choose an option (1-4):");
       int choice = int.Parse(Console.ReadLine());
        Console.Write("Enter first number:");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        double num2 = double.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Result = " + (num1 + num2));
                break;

            case 2:
                Console.WriteLine("Result = " + (num1 - num2));
                break;

            case 3:
                Console.WriteLine("Result = " + (num1 * num2));
                break;

            case 4:
                if (num2 != 0)
                {
                    Console.WriteLine("Result = " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
       }
        
        
    }
}