using System;

class Program
{
    
    static void Main()
    {
       Console.WriteLine("1.Warrior");
       Console.WriteLine("2.Mage");
       Console.WriteLine("3.Archer");
       Console.Write("choose your class:");
       int choice = int.Parse(Console.ReadLine());
       
       switch(choice)
       {
        case 1:
            Console.WriteLine("You choose Warrior");
            break;
            case 2:
            Console.WriteLine("you choose Mage");
            break;
            case 3:
            Console.WriteLine("you choose Archer");
            break;
       }
        
        
    }
}