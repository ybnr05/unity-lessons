using System;

class Program
{
    static void Main()
    {
        string password = "";

        while (password != "csharp")
        {
            Console.Write("Enter Password: ");
            password = Console.ReadLine();

            if (password != "csharp")
            {
                Console.WriteLine("Wrong Password!");
            }
        }

        Console.WriteLine("Access Granted!");
    }
}