using NUnit.Framework;

[TestFixture] 
public class StringUtilsTests
{
    private StringUtils stringUtils;

    [SetUp] 
    public void Setup()
    {
        stringUtils = new StringUtils();
    }

    [Test] 
    public void Reverse_ShouldReturnReversedString()
    {
        string result = stringUtils.Reverse("hello");
        Assert.AreEqual("olleh", result);
    }

    [Test] 
    public void IsPalindrome_ShouldReturnTrue_WhenPalindrome()
    {
        bool result = stringUtils.IsPalindrome("madam");
        Assert.IsTrue(result);
    }

    [Test] 
    public void IsPalindrome_ShouldReturnFalse_WhenNotPalindrome()
    {
        bool result = stringUtils.IsPalindrome("hello");
        Assert.IsFalse(result);
    }

    [Test] 
    public void ToUpperCase_ShouldConvertToUpperCase()
    {
        string result = stringUtils.ToUpperCase("hello");
        Assert.AreEqual("HELLO", result);
    }
}
