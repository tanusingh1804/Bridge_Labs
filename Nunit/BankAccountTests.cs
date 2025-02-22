using NUnit.Framework;
using System;

[TestFixture] 
public class BankAccountTests
{
    private BankAccount account;

    [SetUp] 
    public void Setup()
    {
        account = new BankAccount(1000); 
    }

    
    [Test]
    public void Deposit_ShouldIncreaseBalance()
    {
        account.Deposit(500);
        Assert.AreEqual(1500, account.GetBalance());
    }

   
    [Test]
    public void Withdraw_ShouldDecreaseBalance_WhenFundsAreSufficient()
    {
        bool result = account.Withdraw(300);
        Assert.IsTrue(result);
        Assert.AreEqual(700, account.GetBalance());
    }

   
    [Test]
    public void Withdraw_ShouldFail_WhenFundsAreInsufficient()
    {
        bool result = account.Withdraw(1500); 
        Assert.IsFalse(result);
        Assert.AreEqual(1000, account.GetBalance()); 
    }

   
    [Test]
    public void Deposit_ShouldThrowException_WhenAmountIsNegative()
    {
        Assert.Throws<ArgumentException>(() => account.Deposit(-500));
    }

    
    [Test]
    public void Withdraw_ShouldThrowException_WhenAmountIsNegative()
    {
        Assert.Throws<ArgumentException>(() => account.Withdraw(-200));
    }
}
