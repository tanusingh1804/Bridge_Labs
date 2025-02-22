using NUnit.Framework;

[TestFixture]
public class TemperatureConverterTests
{
    private TemperatureConverter converter;

    [SetUp]
    public void Setup()
    {
        converter = new TemperatureConverter();
    }

    [Test]
    public void CelsiusToFahrenheit_ShouldReturnCorrectValue()
    {
        double result = converter.CelsiusToFahrenheit(0);
        Assert.AreEqual(32, result, 0.001);
    }

    [Test]
    public void FahrenheitToCelsius_ShouldReturnCorrectValue()
    {
        double result = converter.FahrenheitToCelsius(32);
        Assert.AreEqual(0, result, 0.001);
    }

    [Test]
    public void CelsiusToFahrenheit_ShouldConvertBoilingPoint()
    {
        double result = converter.CelsiusToFahrenheit(100);
        Assert.AreEqual(212, result, 0.001);
    }

    [Test]
    public void FahrenheitToCelsius_ShouldConvertBoilingPoint()
    {
        double result = converter.FahrenheitToCelsius(212);
        Assert.AreEqual(100, result, 0.001);
    }
}
