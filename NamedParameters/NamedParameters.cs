using System;

namespace DotNetTutorials.NamedParameters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Using Named Parameter while calling Method
            Test(1, 2); //a = 1 and b = 2 and c = 20 by default value
            Test(1, c: 2); //a = 1 and b = 10 by default and c = 2
            //Order is not Important with Named Parameter
            Test(b: 1, c: 2, a: 10);
            Console.ReadLine();
        }

        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine($"a = {a}, b = {b}, c= {c}");
        }
    }
}