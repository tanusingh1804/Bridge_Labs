using System;
using System.Text.RegularExpressions;

public class UserRegistration
{
   
    public string RegisterUser(string username, string email, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
            throw new ArgumentException("Username must be at least 3 characters long.");

        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            throw new ArgumentException("Invalid email format.");

        if (password.Length < 8 || !Regex.IsMatch(password, @"[A-Z]") || !Regex.IsMatch(password, @"\d"))
            throw new ArgumentException("Password must be at least 8 characters long, contain one uppercase letter and one number.");

        return "User registered successfully!";
    }
}
