using NUnit.Framework;
using System;

[TestFixture]
public class DateFormatterTests
{
    private DateFormatter formatter;

    [SetUp] 
    public void Setup()
    {
        formatter = new DateFormatter();
    }

  
    [Test]
    public void FormatDate_ShouldReturnCorrectFormat_ForValidDate()
    {
        string result = formatter.FormatDate("2025-02-22");
        Assert.AreEqual("22-02-2025", result);
    }

    [Test]
    public void FormatDate_ShouldConvertCorrectly()
    {
        string result = formatter.FormatDate("2000-12-31");
        Assert.AreEqual("31-12-2000", result);
    }

  
    [Test]
    public void FormatDate_ShouldThrowException_ForInvalidFormat()
    {
        var ex = Assert.Throws<ArgumentException>(() => formatter.FormatDate("22-02-2025"));
        Assert.AreEqual("Invalid date format. Use yyyy-MM-dd.", ex.Message);
    }

    [Test]
    public void FormatDate_ShouldThrowException_ForNonDateString()
    {
        var ex = Assert.Throws<ArgumentException>(() => formatter.FormatDate("invalid-date"));
        Assert.AreEqual("Invalid date format. Use yyyy-MM-dd.", ex.Message);
    }
}
