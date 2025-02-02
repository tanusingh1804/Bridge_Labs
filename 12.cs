using System;

class Program
{
    static void Main()
    {
        SavingsAccount account = new SavingsAccount("987654", "Alice", 5000);
        account.Deposit(2000);
        Console.WriteLine("Balance: " + account.GetBalance());
    }
}

class BankAccount
{
    public string AccountNumber;
    protected string AccountHolder;
    private double Balance;

    public BankAccount(string accountNumber, string accountHolder, double balance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public double GetBalance()
    {
        return Balance;
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder, balance) { }
}
