using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
class MaxLengthAttribute : Attribute
{
   public int Length { get; }

   public MaxLengthAttribute(int length)
   {
       Length = length;
   }
}

class User
{
   [MaxLength(10)]
   public string Username { get; }

   public User(string username)
   {
       ValidateMaxLength(this, nameof(Username), username);
       Username = username;
   }

   private void ValidateMaxLength(object obj, string fieldName, string value)
   {
       FieldInfo field = obj.GetType().GetField(fieldName, BindingFlags.Public | BindingFlags.Instance);
       if (field != null)
       {
           MaxLengthAttribute maxLengthAttr = field.GetCustomAttribute<MaxLengthAttribute>();
           if (maxLengthAttr != null && value.Length > maxLengthAttr.Length)
           {
               throw new ArgumentException($"{fieldName} exceeds max length of {maxLengthAttr.Length} characters.");
           }
       }
   }
}

class Program8
{
   static void Main(string[] args)
   {
       try
       {
           User validUser = new User("Rahul");
           Console.WriteLine($"Valid Username: {validUser.Username}");

           User invalidUser = new User("VeryLongUsername");
           Console.WriteLine($"Invalid Username: {invalidUser.Username}");
       }
       catch (ArgumentException ex)
       {
           Console.WriteLine($"Error: {ex.Message}");
       }
   }
}

