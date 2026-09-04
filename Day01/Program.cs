using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter player name: ");
        string playername = Console.ReadLine();
        Console.Write("Enter Health");
        int health = int.Parse(Console.ReadLine());
        Console.Write("Enter level");
        int level = int.Parse(Console.ReadLine());
        
        
        Console.WriteLine();
        Console.WriteLine("=========================");
        Console.WriteLine("PLAYER REPORT");
        Console.WriteLine("=========================");
        

        Console.WriteLine("Name:" + playername);
        Console.WriteLine("Health:" + health);
        Console.WriteLine("Level" + level);
        
        
    }
}