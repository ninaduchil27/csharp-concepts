using System;

class Program
{
    static void Main (String[] args)
    {
        int x, y, result;
        try
        {
        Console.WriteLine("Enter first number: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        y = int.Parse(Console.ReadLine());
        result = x / y;
        Console.WriteLine($"Result: {result}");       
        }
        catch(FormatException fe)
        {
            Console.WriteLine("Caught FormatException");
        }
        catch(DivideByZeroException dbze)
        {
            Console.WriteLine("Caught DivideByZeroException");
        }
        catch(Exception e)
        {
            Console.WriteLine("Generic catch block");
        }
        finally
        {
            Console.WriteLine("Executed successfully");
        }
    }
}