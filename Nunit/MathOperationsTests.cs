using NUnit.Framework;
using System;

[TestFixture] 
public class MathOperationsTests
{
    private MathOperations mathOperations;

    [SetUp]
    public void Setup()
    {
        mathOperations = new MathOperations();
    }

    [Test] 
    public void Divide_ShouldThrowArithmeticException_WhenDividingByZero()
    {
        Assert.Throws<ArithmeticException>(() => mathOperations.Divide(10, 0));
    }

    [Test] 
    public void Divide_ShouldReturnCorrectResult_WhenValidInputs()
    {
        int result = mathOperations.Divide(10, 2);
        Assert.AreEqual(5, result);
    }
}
