using System;
namespace Day2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            string integerInput = Console.ReadLine();
            if (int.TryParse(integerInput, out int intValue))
            {
                double doubleValueImplicit = intValue;
                int intValueExplicit = (int)doubleValueImplicit;
                Console.WriteLine($"Implicit conversion from int to double: {doubleValueImplicit}");
                Console.WriteLine($"Explicit conversion from double to int: {intValueExplicit}");
                if (intValue != intValueExplicit)
                {
                    Console.WriteLine("Loss of data occurred during explicit conversion.");
                }
                else
                {
                    Console.WriteLine("No loss of data occurred during explicit conversion.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            Console.ReadLine(); // Keep the console window open
        }
    }
}

