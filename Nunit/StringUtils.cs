public class StringUtils
{
 
    public string Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

   
    public bool IsPalindrome(string str)
    {
        string reversed = Reverse(str);
        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }

    public string ToUpperCase(string str)
    {
        return str.ToUpper();
    }
}

