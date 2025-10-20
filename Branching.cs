
using System;

class PackageCostCalculator
{
    static void Main()
    {
        Console.WriteLine("== Welcome to Package Express Shipping Tool ==");

        Console.Write("Please input the package weight in pounds: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal weight))
        {
            Console.WriteLine("Error: Weight must be a valid number.");
            return;
        }

        if (weight > 50)
        {
            Console.WriteLine("Notice: Package exceeds the weight limit for Package Express.");
            return;
        }

        Console.Write("Enter package width (inches): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal width))
        {
            Console.WriteLine("Error: Width must be a number.");
            return;
        }

        Console.Write("Enter package height (inches): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal height))
        {
            Console.WriteLine("Error: Height must be a number.");
            return;
        }

        Console.Write("Enter package length (inches): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal length))
        {
            Console.WriteLine("Error: Length must be a number.");
            return;
        }

        decimal totalDimensions = width + height + length;

        if (totalDimensions > 50)
        {
            Console.WriteLine("Sorry, this package is too large to be shipped via Package Express.");
            return;
        }

        decimal estimatedCost = (width * height * length * weight) / 100;
        Console.WriteLine($"
Shipping Quote: ${estimatedCost:F2}");
        Console.WriteLine("We appreciate your use of Package Express!");
    }
}
