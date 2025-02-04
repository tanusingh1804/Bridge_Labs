using System;

class BankAccount
{
   public static string bankName = "State Bank of India";
   private static int totalAccounts = 0;

   public readonly int AccountNumber;
   public string AccountHolderName { get; set; }
   public double Balance { get; set; }

   public BankAccount(string accountHolderName, double initialBalance)
   {
       this.AccountNumber = ++totalAccounts; 
       this.AccountHolderName = accountHolderName;
       this.Balance = initialBalance;
   }

   public static void GetTotalAccounts()
   {
       Console.WriteLine("Total bank accounts: " + totalAccounts);
   }

   public void DisplayAccountDetails(object obj)
   {
       if (obj is BankAccount account)
       {
           Console.WriteLine("\nAccount Details:");
           Console.WriteLine("Account Number : " + account.AccountNumber);
           Console.WriteLine("Account Holder : " + account.AccountHolderName);
           Console.WriteLine("Balance        : " + account.Balance);
           Console.WriteLine("Bank Name      : " + bankName);
       }
       else
       {
           Console.WriteLine("Invalid object. Cannot display account details.");
       }
   }
}

class Program
{
   static void Main(string[] args)
   {
       Console.Write("Enter number of accounts: ");
       int numAccounts = Convert.ToInt32(Console.ReadLine());

       BankAccount[] accounts = new BankAccount[numAccounts]; 

       for (int i = 0; i < numAccounts; i++)
       {
           Console.WriteLine("\nEnter details for Account " + (i + 1) + ":");

           Console.Write("Enter Account Holder Name: ");
           string name = Console.ReadLine();

           Console.Write("Enter Initial Balance: ");
           double balance = Convert.ToDouble(Console.ReadLine());

           accounts[i] = new BankAccount(name, balance);
       }

       Console.WriteLine("\nAll Account Details:");
       for (int i = 0; i < numAccounts; i++)
       {
           accounts[i].DisplayAccountDetails(accounts[i]);
       }

       BankAccount.GetTotalAccounts();
   }
}

