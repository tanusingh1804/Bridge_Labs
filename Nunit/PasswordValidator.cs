using System;
using System.Text.RegularExpressions;

public class PasswordValidator
{
    
    public bool IsValidPassword(string password)
    {
        if (password.Length < 8)
            return false;

        if (!Regex.IsMatch(password, @"[A-Z]")) 
            return false;

        if (!Regex.IsMatch(password, @"\d")) 
            return false;

        return true;
    }
}
