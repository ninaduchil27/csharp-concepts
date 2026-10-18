using System;

namespace DotNetTutorials.WithoutEncapsulation
{
    class BankAccount
    {
        public decimal Balance;
    }

    public class ProgramWithoutEncapsulation
    {
        public static void Main(String[] args)
        {
            BankAccount bankAccount = new BankAccount();

            Console.WriteLine("Without Encapsulation: Public Balance Field");
            Console.WriteLine("Changing balance...");
            bankAccount.Balance = -500;
 
            Console.WriteLine("Balance changed. Balance:");
            Console.WriteLine(bankAccount.Balance);
        }
    }
}