using NUnit.Framework;

[TestFixture] 
public class PasswordValidatorTests
{
    private PasswordValidator validator;

    [SetUp]
    public void Setup()
    {
        validator = new PasswordValidator();
    }

  
    [Test]
    public void IsValidPassword_ShouldReturnTrue_ForValidPassword()
    {
        bool result = validator.IsValidPassword("StrongP@ss1");
        Assert.IsTrue(result);
    }

    [Test]
    public void IsValidPassword_ShouldReturnFalse_WhenPasswordIsTooShort()
    {
        bool result = validator.IsValidPassword("Short1");
        Assert.IsFalse(result);
    }

    [Test]
    public void IsValidPassword_ShouldReturnFalse_WhenMissingUppercaseLetter()
    {
        bool result = validator.IsValidPassword("weakpassword1");
        Assert.IsFalse(result);
    }

    [Test]
    public void IsValidPassword_ShouldReturnFalse_WhenMissingDigit()
    {
        bool result = validator.IsValidPassword("NoDigitsHere");
        Assert.IsFalse(result);
    }
}
