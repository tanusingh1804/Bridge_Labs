using NUnit.Framework;
using System;

[TestFixture] 
public class UserRegistrationTests
{
    private UserRegistration registration;

    [SetUp] 
    public void Setup()
    {
        registration = new UserRegistration();
    }

    
    [Test]
    public void RegisterUser_ShouldReturnSuccessMessage_ForValidInput()
    {
        string result = registration.RegisterUser("JohnDoe", "john@example.com", "Password123");
        Assert.AreEqual("User registered successfully!", result);
    }


    [Test]
    public void RegisterUser_ShouldThrowException_ForShortUsername()
    {
        var ex = Assert.Throws<ArgumentException>(() => registration.RegisterUser("JD", "john@example.com", "Password123"));
        Assert.AreEqual("Username must be at least 3 characters long.", ex.Message);
    }

   
    [Test]
    public void RegisterUser_ShouldThrowException_ForInvalidEmail()
    {
        var ex = Assert.Throws<ArgumentException>(() => registration.RegisterUser("JohnDoe", "invalid-email", "Password123"));
        Assert.AreEqual("Invalid email format.", ex.Message);
    }

   
    [Test]
    public void RegisterUser_ShouldThrowException_ForWeakPassword_NoUppercase()
    {
        var ex = Assert.Throws<ArgumentException>(() => registration.RegisterUser("JohnDoe", "john@example.com", "password123"));
        Assert.AreEqual("Password must be at least 8 characters long, contain one uppercase letter and one number.", ex.Message);
    }


    [Test]
    public void RegisterUser_ShouldThrowException_ForWeakPassword_NoNumber()
    {
        var ex = Assert.Throws<ArgumentException>(() => registration.RegisterUser("JohnDoe", "john@example.com", "PasswordOnly"));
        Assert.AreEqual("Password must be at least 8 characters long, contain one uppercase letter and one number.", ex.Message);
    }

    [Test]
    public void RegisterUser_ShouldThrowException_ForEmptyInputs()
    {
        var ex = Assert.Throws<ArgumentException>(() => registration.RegisterUser("", "", ""));
        Assert.IsTrue(ex.Message.Contains("Username must be at least 3 characters long"));
    }
}
