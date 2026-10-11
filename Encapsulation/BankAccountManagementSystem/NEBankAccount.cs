
// Not Encapsulated

class BankAccount
{
    public decimal Balance;

}

class MainEntry
{
public static void Main(String[] args)
{

    BankAccount a = new BankAccount();

    Console.WriteLine("Changing balance...");
    a.Balance = -500;
    Console.WriteLine("Balance changed. Balance:");
    Console.WriteLine(a.Balance);
    Console.WriteLine(a.Balance);

}

}