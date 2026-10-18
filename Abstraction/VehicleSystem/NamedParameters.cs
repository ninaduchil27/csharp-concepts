using System;

namespace NamedParameter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Test(1, 2); 
            Test(1, c: 2);
            
            Test(b: 1, c: 2, a: 10);
            Console.ReadLine();
        }

        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine($"a = {a}, b = {b}, c= {c}");
        }
    }
}