using System;
 
namespace DotNetTutorials.ExceptionHandling
{
    class Program
    {
        public static void Main (string[] args)
        {
            int firstNumber, secondNumber, result;

            try
            {
                Console.WriteLine("Enter first number:");
                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                secondNumber = Convert.ToInt32(Console.ReadLine());
            
                result = firstNumber / secondNumber;
                Console.WriteLine($"Result: {result}");       
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number format.");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch(Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }
}