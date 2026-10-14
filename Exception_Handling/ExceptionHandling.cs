using System;

class Program
{
    public static void Main (string[] args)
    {
        int firstNumber, secondNumber, result;

        try
        {
            Console.WriteLine("Enter first number:");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            secondNumber = int.Parse(Console.ReadLine());
            
            result = firstNumber / secondNumber;
            Console.WriteLine($"Result: {result}");       
        }
        catch(FormatException fe)
        {
            Console.WriteLine("Invalid number format.");
        }
        catch(DivideByZeroException dbze)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        catch(Exception e)
        {
            Console.WriteLine("An unexpected error occured.");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}