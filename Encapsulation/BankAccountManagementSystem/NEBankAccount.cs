
// Not Encapsulated

class NEBankAccount
{
    public decimal Balance;

}

class MainEntry
{
public static void Main(String[] args)
{

    NEBankAccount a = new NEBankAccount();

    Console.WriteLine("Changing balance...");
    a.Balance = -500;
    Console.WriteLine("Balance changed. Balance:");
    Console.WriteLine(a.Balance);
    Console.WriteLine(a.Balance);

}

}