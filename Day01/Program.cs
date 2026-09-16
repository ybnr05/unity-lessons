using System;

class Car
{
    // Fields
    public string Brand;
    public string Model;
    public int Year;
    public string Color;

    // Constructor
    public Car(string brand, string model, int year, string color)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
    }

    // Method
    public void DisplayCar()
    {
        Console.WriteLine("Brand : " + Brand);
        Console.WriteLine("Model : " + Model);
        Console.WriteLine("Year  : " + Year);
        Console.WriteLine("Color : " + Color);
        Console.WriteLine("----------------------------");
    }
}

class Program
{
    static void Main()
    {
        // Creating three car objects
        Car car1 = new Car("Toyota", "Corolla", 2023, "White");
        Car car2 = new Car("Honda", "Civic", 2022, "Black");
        Car car3 = new Car("Tesla", "Model 3", 2024, "Red");

        Console.WriteLine("========== CAR DETAILS ==========\n");

        car1.DisplayCar();
        car2.DisplayCar();
        car3.DisplayCar();
    }
}