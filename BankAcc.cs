//using System;
//using System.Collections.Generic;

//class Account
//{
//    public int AccNo { get; }
//    public double Balance { get; }

//    public Account(int accNo, double balance)
//    {
//        AccNo = accNo;
//        Balance = balance;
//    }
//}

//class Customer
//{
//    public string Name { get; }
//    public List<Account> Accounts { get; } = new List<Account>();

//    public Customer(string name)
//    {
//        Name = name;
//    }
//}

//class Bank
//{
//    public string Name { get; }
//    public List<Customer> Customers { get; } = new List<Customer>();

//    public Bank(string name)
//    {
//        Name = name;
//    }

//    public void OpenAccount(Customer customer, Account account)
//    {
//        customer.Accounts.Add(account);
//        if (!Customers.Contains(customer))
//            Customers.Add(customer);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter bank name: ");
//        string bankName = Console.ReadLine();
//        Bank bank = new Bank(bankName);

//        Console.Write("Enter number of customers: ");
//        if (!int.TryParse(Console.ReadLine(), out int customerCount) || customerCount <= 0)
//        {
//            Console.WriteLine("Invalid input!");
//            return;
//        }

//        for (int i = 0; i < customerCount; i++)
//        {
//            Console.Write($"\nEnter customer {i + 1} name: ");
//            string customerName = Console.ReadLine();
//            Customer customer = new Customer(customerName);

//            Console.Write("Enter number of accounts: ");
//            if (!int.TryParse(Console.ReadLine(), out int accountCount) || accountCount <= 0)
//            {
//                Console.WriteLine("Invalid input!");
//                continue;
//            }

//            for (int j = 0; j < accountCount; j++)
//            {
//                Console.Write($"Enter account {j + 1} number: ");
//                if (!int.TryParse(Console.ReadLine(), out int accNo))
//                {
//                    Console.WriteLine("Invalid account number!");
//                    continue;
//                }

//                Console.Write("Enter balance: ");
//                if (!double.TryParse(Console.ReadLine(), out double balance) || balance < 0)
//                {
//                    Console.WriteLine("Invalid balance!");
//                    continue;
//                }

//                bank.OpenAccount(customer, new Account(accNo, balance));
//            }
//        }

//        Console.WriteLine("\nCustomer Accounts:");
//        foreach (Customer customer in bank.Customers)
//        {
//            Console.WriteLine($"\n{customer.Name}'s Accounts:");
//            foreach (Account account in customer.Accounts)
//            {
//                Console.WriteLine($"Account No: {account.AccNo}, Balance: {account.Balance}");
//            }
//        }
//    }
//}
