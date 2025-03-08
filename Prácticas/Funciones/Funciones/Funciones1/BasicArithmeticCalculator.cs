using System;

class Program
{
    static void Main()
    {
        Welcome();

        // Variables to hold numbers and operation
        int n1 = RequestNumber("Enter the first number (n1): ");
        int n2 = RequestNumber("Enter the second number (n2): ");
        int operation = RequestOperation();

        // Using switch case to handle operations
        switch (operation)
        {
            case 1:
                Console.WriteLine($"Result: {Add(n1, n2)}");
                break;
            case 2:
                Console.WriteLine($"Result: {Subtract(n1, n2)}");
                break;
            case 3:
                Console.WriteLine($"Result: {Multiply(n1, n2)}");
                break;
            case 4:
                var result = Divide(n1, n2);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    Console.WriteLine($"Result: {result}");
                }
                break;
            default:
                Console.WriteLine("Invalid operation selected.");
                break;
        }
    }

    private static void Welcome()
    {
        Console.WriteLine("Welcome to the BASIC CALCULATOR.");
    }

    private static int RequestNumber(string prompt)
    {
        int number;
        Console.WriteLine(prompt);
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.WriteLine(prompt);
        }
        return number;
    }

    private static int RequestOperation()
    {
        int operation;
        Console.WriteLine("Select an operation:");
        Console.WriteLine("1 - Add");
        Console.WriteLine("2 - Subtract");
        Console.WriteLine("3 - Multiply");
        Console.WriteLine("4 - Divide");
        while (!int.TryParse(Console.ReadLine(), out operation) || operation < 1 || operation > 4)
        {
            Console.WriteLine("Invalid operation. Please enter a number between 1 and 4.");
        }
        return operation;
    }

    private static int Add(int n1, int n2)
    {
        return n1 + n2;
    }

    private static int Subtract(int n1, int n2)
    {
        return n1 - n2;
    }

    private static int Multiply(int n1, int n2)
    {
        return n1 * n2;
    }

    private static double Divide(int n1, int n2)
    {
        if (n2 == 0)
        {
            return double.NaN;
        }
        return (double)n1 / n2;
    }
}
