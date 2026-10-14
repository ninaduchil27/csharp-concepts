using System;

class BankAccount
{
    private decimal _balance;
    public decimal Balance
    {
        get { return _balance; }  
    }
    public BankAccount (decimal initialBalance)
    {
        if (initialBalance > 0)
        {
            _balance = initialBalance;
        }
        else
        {
            Console.WriteLine("Initial balance cannot be negative.");
        }
    }

    public void Withdraw(decimal amount)
    {        
        if (amount>0 && amount <= _balance)
        {
            _balance -= amount;
        }
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    
    }
}

class Program
{
    public static void Main (string[] args)
    {
        BankAccount bankAccount = new BankAccount(900);
        Console.WriteLine("Initial Balance: " + bankAccount.Balance);
        
        bankAccount.Withdraw(100);
        Console.WriteLine("Amount Withdrawn. New Balance: " + bankAccount.Balance); 
        bankAccount.Deposit(500);
        Console.WriteLine("Amount Deposited. New Balance: " + bankAccount.Balance); 
    }
}