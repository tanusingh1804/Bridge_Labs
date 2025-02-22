using NUnit.Framework;

[TestFixture] 
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp] 
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test] 
    public void Add_ShouldReturnSum_WhenGivenTwoNumbers()
    {
        int result = calculator.Add(5, 3);
        Assert.AreEqual(8, result);
    }

    [Test] 
    public void Subtract_ShouldReturnDifference_WhenGivenTwoNumbers()
    {
        int result = calculator.Subtract(10, 5);
        Assert.AreEqual(5, result);
    }

    [Test] 
    public void Multiply_ShouldReturnProduct_WhenGivenTwoNumbers()
    {
        int result = calculator.Multiply(4, 3);
        Assert.AreEqual(12, result);
    }

    [Test] 
    public void Divide_ShouldReturnQuotient_WhenGivenTwoNumbers()
    {
        int result = calculator.Divide(10, 2);
        Assert.AreEqual(5, result);
    }

    [Test] 
    public void Divide_ShouldThrowException_WhenDividingByZero()
    {
        Assert.Throws<System.DivideByZeroException>(() => calculator.Divide(10, 0));
    }
}

