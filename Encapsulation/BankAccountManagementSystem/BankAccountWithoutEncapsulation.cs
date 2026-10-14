class BankAccount
{
    public decimal Balance;
}

class Program
{
    public static void Main(String[] args)
    {
    BankAccount bankAccount = new BankAccount();

    Console.WriteLine("Changing balance...");
    bankAccount.Balance = -500;

    Console.WriteLine("Balance changed. Balance:");
    Console.WriteLine(bankAccount.Balance);
    }
}