
// Encapsulated

using System;

class EBankAccount
{
    private decimal balance;
    public decimal Balance
    {
        get { return balance; }  
    }
    public EBankAccount (decimal initialBalance) {
        if (initialBalance > 0)
        {
        balance = initialBalance;
        }
        else
        {
        Console.WriteLine("Intial balance cannot be negative");
        }
    }

    public void Withdraw(decimal amount)
    {
        
        if (amount>0 && amount <= balance)
        {
            balance -= amount;
        }

    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    
    }

}

class MainEntry
{
    public static void Main (string[] args)
    {
        EBankAccount a = new EBankAccount(900);
        Console.WriteLine("Initial Balance: " + a.Balance);
        
        a.Withdraw(100);
        Console.WriteLine("Amount Withdrawn. New Balance: " + a.Balance); 
        a.Deposit(500);
        Console.WriteLine("Amount Deposited. New Balance: " + a.Balance); 

    }

}