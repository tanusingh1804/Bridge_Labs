public class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");

        balance += amount;
    }

  
    public bool Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");

        if (amount > balance)
            return false; 

        balance -= amount;
        return true;
    }

   
    public double GetBalance()
    {
        return balance;
    }
}
